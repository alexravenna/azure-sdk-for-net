// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    internal partial class WorkflowRunActionRepetitionsRequestHistoriesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkflowRunActionRepetitionsRequestHistoriesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkflowRunActionRepetitionsRequestHistoriesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/requestHistories", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/requestHistories", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List a workflow run repetition request history. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RequestHistoryListResult>> ListAsync(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RequestHistoryListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = RequestHistoryListResult.DeserializeRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List a workflow run repetition request history. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RequestHistoryListResult> List(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RequestHistoryListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = RequestHistoryListResult.DeserializeRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, string requestHistoryName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/requestHistories/", false);
            uri.AppendPath(requestHistoryName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, string requestHistoryName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/requestHistories/", false);
            uri.AppendPath(requestHistoryName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a workflow run repetition request history. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/>, <paramref name="repetitionName"/> or <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/>, <paramref name="repetitionName"/> or <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WebAppRequestHistoryData>> GetAsync(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName, requestHistoryName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WebAppRequestHistoryData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = WebAppRequestHistoryData.DeserializeWebAppRequestHistoryData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((WebAppRequestHistoryData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a workflow run repetition request history. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="requestHistoryName"> The request history name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/>, <paramref name="repetitionName"/> or <paramref name="requestHistoryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/>, <paramref name="repetitionName"/> or <paramref name="requestHistoryName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WebAppRequestHistoryData> Get(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, string requestHistoryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));
            Argument.AssertNotNullOrEmpty(requestHistoryName, nameof(requestHistoryName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName, requestHistoryName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WebAppRequestHistoryData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = WebAppRequestHistoryData.DeserializeWebAppRequestHistoryData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((WebAppRequestHistoryData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List a workflow run repetition request history. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RequestHistoryListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RequestHistoryListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = RequestHistoryListResult.DeserializeRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List a workflow run repetition request history. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RequestHistoryListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RequestHistoryListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = RequestHistoryListResult.DeserializeRequestHistoryListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
