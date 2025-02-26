﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using ClientModel.Tests;
using ClientModel.Tests.Mocks;
using NUnit.Framework;

namespace System.ClientModel.Tests.Pipeline;

public class ClientRetryPolicyTests : SyncAsyncTestBase
{
    public ClientRetryPolicyTests(bool isAsync) : base(isAsync)
    {
    }

    [Test]
    public async Task RetriesErrorResponse()
    {
        ClientPipelineOptions options = new()
        {
            Transport = new MockPipelineTransport("Transport", new int[] { 429, 200 })
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;

        // We visited the transport twice due to retries
        Assert.AreEqual(2, observations.Count);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);

        Assert.AreEqual(200, message.Response!.Status);
    }

    [Test]
    public async Task DoesNotExceedRetryCount()
    {
        ClientPipelineOptions options = new()
        {
            Transport = new MockPipelineTransport("Transport", _ => new MockPipelineResponse(500))
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;

        // We visited the transport four times due to default max 3 retries
        Assert.AreEqual(4, observations.Count);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);

        Assert.AreEqual(500, message.Response!.Status);
    }

    [Test]
    public async Task CanConfigureMaxRetryCount()
    {
        int maxRetryCount = 10;

        ClientPipelineOptions options = new()
        {
            RetryPolicy = new MockRetryPolicy(maxRetryCount, i => TimeSpan.FromMilliseconds(10)),
            Transport = new MockPipelineTransport("Transport", _ => new MockPipelineResponse(500))
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;
        int observationCount = maxRetryCount + 1;

        Assert.AreEqual(observationCount, observations.Count);
        for (int i = 0; i < observationCount; i++)
        {
            Assert.AreEqual("Transport:Transport", observations[index++]);
        }

        Assert.AreEqual(500, message.Response!.Status);
    }

    [Test]
    public async Task OnlyRetriesRetriableCodes()
    {
        // Retriable codes are hard-coded into the ClientModel retry policy today:
        // 408, 429, 500, 502, 503, and 504.  501 should not be retried.

        ClientPipelineOptions options = new()
        {
            RetryPolicy = new MockRetryPolicy(maxRetries: 10, i => TimeSpan.FromMilliseconds(10)),
            Transport = new MockPipelineTransport("Transport",
                new int[] { 408, 429, 500, 502, 503, 504, 501 })
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        List<string> observations = ObservablePolicy.GetData(message);

        int observationCount = 7;
        int index = 0;

        // We visited the transport seven times and stopped on the 501 response.
        Assert.AreEqual(observationCount, observations.Count);
        for (int i = 0; i < observationCount; i++)
        {
            Assert.AreEqual("Transport:Transport", observations[index++]);
        }

        Assert.AreEqual(501, message.Response!.Status);
    }

    [Test]
    [TestCaseSource(nameof(RetryAfterTestValues))]
    public void RespectsRetryAfterHeader(string headerName, string headerValue, double expected)
    {
        MockRetryPolicy retryPolicy = new();
        MockPipelineMessage message = new();
        MockPipelineResponse response = new();
        response.SetHeader(headerName, headerValue);
        message.SetResponse(response);

        // Default delay with exponential backoff for second try is 1600 ms.
        double delayMillis = retryPolicy.GetNextDelayMilliseconds(message, 2);
        Assert.AreEqual(expected, delayMillis);
    }

    [Test]
    public void RespectsRetryAfterDateHeader()
    {
        MockRetryPolicy retryPolicy = new();
        MockPipelineMessage message = new();
        MockPipelineResponse response = new();

        // Retry after 100 seconds from now
        response.SetHeader(
            "Retry-After",
            (DateTimeOffset.Now + TimeSpan.FromSeconds(100)).ToString("R"));
        message.SetResponse(response);

        // Default delay with exponential backoff for second try is 1600 ms.
        double delayMillis = retryPolicy.GetNextDelayMilliseconds(message, 2);

        // Retry-After header is larger - wait the Retry-After time, which
        // should be approx 100s, so test for > 20s.
        Assert.GreaterOrEqual(delayMillis, 20 * 1000);
    }

    [Test]
    public async Task ShouldRetryIsCalledOnlyForErrors()
    {
        Exception retriableException = new IOException();
        int retryCount = 0;

        MockRetryPolicy retryPolicy = new();
        MockPipelineTransport transport = new("Transport", responseFactory);

        MockPipelineResponse responseFactory(PipelineMessage m)
            => retryCount++ switch
            {
                0 => new MockPipelineResponse(500),
                1 => throw retriableException,
                2 => new MockPipelineResponse(200),
                _ => throw new InvalidOperationException(),
            };

        ClientPipelineOptions options = new()
        {
            RetryPolicy = retryPolicy,
            Transport = transport,
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        // Validate the state of the retry policy at the transport.
        transport.OnSendingRequest = _ =>
        {
            switch (retryCount)
            {
                case 0:
                    Assert.IsFalse(retryPolicy.ShouldRetryCalled);
                    Assert.IsNull(retryPolicy.LastException);
                    break;
                case 1:
                    Assert.IsTrue(retryPolicy.ShouldRetryCalled);
                    Assert.IsNull(retryPolicy.LastException);
                    retryPolicy.Reset();
                    break;
                case 2:
                    Assert.IsTrue(retryPolicy.ShouldRetryCalled);
                    Assert.AreSame(retriableException, retryPolicy.LastException);
                    retryPolicy.Reset();
                    break;
                default:
                    throw new InvalidOperationException();
            }
        };

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        // Validate last iteration through retry policy handling, i.e. after 200 response
        Assert.IsFalse(retryPolicy.ShouldRetryCalled);
        Assert.IsNull(retryPolicy.LastException);

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;

        // We visited the transport three times due to retries
        Assert.AreEqual(3, observations.Count);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);

        Assert.AreEqual(200, message.Response!.Status);
    }

    [Test]
    public async Task CallbacksAreCalledForErrorResponseAndException()
    {
        Exception retriableException = new IOException();
        int retryCount = 0;

        MockRetryPolicy retryPolicy = new();
        MockPipelineTransport transport = new("Transport", responseFactory);

        MockPipelineResponse responseFactory(PipelineMessage m)
            => retryCount++ switch
            {
                0 => new MockPipelineResponse(500),
                1 => throw retriableException,
                2 => new MockPipelineResponse(200),
                _ => throw new InvalidOperationException(),
            };

        ClientPipelineOptions options = new()
        {
            RetryPolicy = retryPolicy,
            Transport = transport,
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        // Validate the state of the retry policy at the transport.
        transport.OnSendingRequest = i =>
        {
            switch (retryCount)
            {
                case 0:
                    Assert.IsTrue(retryPolicy.OnSendingRequestCalled);
                    Assert.IsFalse(retryPolicy.OnRequestSentCalled);
                    Assert.IsNull(retryPolicy.LastException);
                    break;
                case 1:
                    Assert.IsTrue(retryPolicy.OnSendingRequestCalled);
                    Assert.IsTrue(retryPolicy.OnRequestSentCalled);
                    Assert.IsNull(retryPolicy.LastException);
                    retryPolicy.Reset();
                    break;
                case 2:
                    Assert.IsTrue(retryPolicy.OnSendingRequestCalled);
                    Assert.IsTrue(retryPolicy.OnRequestSentCalled);
                    Assert.AreSame(retriableException, retryPolicy.LastException);
                    retryPolicy.Reset();
                    break;
                default:
                    throw new InvalidOperationException();
            }
        };

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        // Validate last iteration through retry policy handling, i.e. after 200 response
        Assert.IsFalse(retryPolicy.OnSendingRequestCalled);
        Assert.IsTrue(retryPolicy.OnRequestSentCalled);
        Assert.IsNull(retryPolicy.LastException);

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;

        // We visited the transport three times due to retries
        Assert.AreEqual(3, observations.Count);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);

        Assert.AreEqual(200, message.Response!.Status);
    }

    [Test]
    public async Task RetriesWithPolly()
    {
        ClientPipelineOptions options = new()
        {
            RetryPolicy = new PollyRetryPolicy(),
            Transport = new MockPipelineTransport("Transport", new int[] { 429, 200 })
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        await pipeline.SendSyncOrAsync(message, IsAsync);

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;

        // We visited the transport twice due to retries
        Assert.AreEqual(2, observations.Count);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);

        Assert.AreEqual(200, message.Response!.Status);
    }

    [Test]
    public void RethrowsAggregateExceptionAfterMaxRetryCount()
    {
        List<Exception> exceptions = new() {
            new IOException(),
            new IOException(),
            new IOException(),
            new IOException() };
        int retryCount = 0;

        MockRetryPolicy retryPolicy = new MockRetryPolicy();
        MockPipelineTransport transport = new MockPipelineTransport("Transport", responseFactory);

        MockPipelineResponse responseFactory(PipelineMessage i)
            => retryCount++ switch
            {
                0 => throw exceptions[0],
                1 => throw exceptions[1],
                2 => throw exceptions[2],
                3 => throw exceptions[3],
                _ => throw new InvalidOperationException(),
            };

        ClientPipelineOptions options = new()
        {
            RetryPolicy = retryPolicy,
            Transport = transport,
        };
        ClientPipeline pipeline = ClientPipeline.Create(options);

        PipelineMessage message = pipeline.CreateMessage();
        AggregateException? exception = Assert.ThrowsAsync<AggregateException>(async ()
            => await pipeline.SendSyncOrAsync(message, IsAsync));

        List<string> observations = ObservablePolicy.GetData(message);

        int index = 0;

        // We visited the transport four times due to retries
        Assert.AreEqual(4, observations.Count);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);
        Assert.AreEqual("Transport:Transport", observations[index++]);

        StringAssert.StartsWith("Retry failed after 4 tries.", exception!.Message);
        CollectionAssert.AreEqual(exceptions, exception.InnerExceptions);
    }

    [Test]
    public void WaitThrowsOnCancellation()
    {
        MockRetryPolicy retryPolicy = new();

        CancellationTokenSource cts = new CancellationTokenSource();

        cts.Cancel();

        TimeSpan delay = TimeSpan.FromMinutes(1);

        Assert.ThrowsAsync<TaskCanceledException>(async () =>
            await retryPolicy.WaitSyncOrAsync(delay, cts.Token, IsAsync));
    }

    #region Helpers
    public static IEnumerable<object[]> RetryAfterTestValues()
    {
        // Retry-After header is larger - wait Retry-After time
        yield return new object[] { "Retry-After", "5", 5000 };

        // Retry-After header is smaller - wait exponential backoff time
        yield return new object[] { "Retry-After", "1", 1600 };

        // Not standard HTTP header - wait exponential backoff time
        yield return new object[] { "retry-after-ms", "5", 1600 };

        // No Retry-After header - wait exponential backoff time
        yield return new object[] { "Content-Type", "application/json", 1600 };

        // Retry-After header is smaller - wait exponential backoff
        yield return new object[] { "Retry-After",
            (DateTimeOffset.Now + TimeSpan.FromSeconds(1)).ToString("R"),
            1600 };
    }
    #endregion
}
