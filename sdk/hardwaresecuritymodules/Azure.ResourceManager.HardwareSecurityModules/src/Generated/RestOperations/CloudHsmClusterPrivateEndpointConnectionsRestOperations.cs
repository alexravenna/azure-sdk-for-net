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

namespace Azure.ResourceManager.HardwareSecurityModules
{
    internal partial class CloudHsmClusterPrivateEndpointConnectionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CloudHsmClusterPrivateEndpointConnectionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CloudHsmClusterPrivateEndpointConnectionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-06-30-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateRequestUri(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CloudHsmClusterPrivateEndpointConnectionData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(peConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CloudHsmClusterPrivateEndpointConnectionData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(peConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates the private endpoint connection for the Cloud Hsm Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="data"> Parameters of the PrivateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/>, <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudHsmClusterPrivateEndpointConnectionData>> CreateAsync(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CloudHsmClusterPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudHsmClusterPrivateEndpointConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CloudHsmClusterPrivateEndpointConnectionData.DeserializeCloudHsmClusterPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates the private endpoint connection for the Cloud Hsm Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="data"> Parameters of the PrivateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/>, <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudHsmClusterPrivateEndpointConnectionData> Create(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CloudHsmClusterPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudHsmClusterPrivateEndpointConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CloudHsmClusterPrivateEndpointConnectionData.DeserializeCloudHsmClusterPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(peConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(peConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the private endpoint connection for the Cloud Hsm Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the private endpoint connection for the Cloud Hsm Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(peConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName)
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
            uri.AppendPath("/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/", false);
            uri.AppendPath(cloudHsmClusterName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(peConnectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the private endpoint connection for the Cloud Hsm Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudHsmClusterPrivateEndpointConnectionData>> GetAsync(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudHsmClusterPrivateEndpointConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = CloudHsmClusterPrivateEndpointConnectionData.DeserializeCloudHsmClusterPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CloudHsmClusterPrivateEndpointConnectionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the private endpoint connection for the Cloud Hsm Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudHsmClusterName"> The name of the Cloud HSM Cluster within the specified resource group. Cloud HSM Cluster names must be between 3 and 23 characters in length. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudHsmClusterName"/> or <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudHsmClusterPrivateEndpointConnectionData> Get(string subscriptionId, string resourceGroupName, string cloudHsmClusterName, string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudHsmClusterName, nameof(cloudHsmClusterName));
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudHsmClusterPrivateEndpointConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = CloudHsmClusterPrivateEndpointConnectionData.DeserializeCloudHsmClusterPrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CloudHsmClusterPrivateEndpointConnectionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
