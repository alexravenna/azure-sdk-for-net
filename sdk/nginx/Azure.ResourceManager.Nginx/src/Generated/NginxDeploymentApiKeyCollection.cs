// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Nginx.Models;

namespace Azure.ResourceManager.Nginx
{
    /// <summary>
    /// A class representing a collection of <see cref="NginxDeploymentApiKeyResource"/> and their operations.
    /// Each <see cref="NginxDeploymentApiKeyResource"/> in the collection will belong to the same instance of <see cref="NginxDeploymentResource"/>.
    /// To get a <see cref="NginxDeploymentApiKeyCollection"/> instance call the GetNginxDeploymentApiKeys method from an instance of <see cref="NginxDeploymentResource"/>.
    /// </summary>
    public partial class NginxDeploymentApiKeyCollection : ArmCollection, IEnumerable<NginxDeploymentApiKeyResource>, IAsyncEnumerable<NginxDeploymentApiKeyResource>
    {
        private readonly ClientDiagnostics _nginxDeploymentApiKeyApiKeysClientDiagnostics;
        private readonly ApiKeysRestOperations _nginxDeploymentApiKeyApiKeysRestClient;

        /// <summary> Initializes a new instance of the <see cref="NginxDeploymentApiKeyCollection"/> class for mocking. </summary>
        protected NginxDeploymentApiKeyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NginxDeploymentApiKeyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NginxDeploymentApiKeyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _nginxDeploymentApiKeyApiKeysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Nginx", NginxDeploymentApiKeyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NginxDeploymentApiKeyResource.ResourceType, out string nginxDeploymentApiKeyApiKeysApiVersion);
            _nginxDeploymentApiKeyApiKeysRestClient = new ApiKeysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, nginxDeploymentApiKeyApiKeysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NginxDeploymentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NginxDeploymentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an API Key for the Nginx deployment in order to access the dataplane API endpoint
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="content"> The API Key object containing fields (e.g. secret text, expiration date) to upsert the key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<NginxDeploymentApiKeyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiKeyName, NginxDeploymentApiKeyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _nginxDeploymentApiKeyApiKeysRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, content, cancellationToken).ConfigureAwait(false);
                var uri = _nginxDeploymentApiKeyApiKeysRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NginxArmOperation<NginxDeploymentApiKeyResource>(Response.FromValue(new NginxDeploymentApiKeyResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an API Key for the Nginx deployment in order to access the dataplane API endpoint
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="content"> The API Key object containing fields (e.g. secret text, expiration date) to upsert the key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<NginxDeploymentApiKeyResource> CreateOrUpdate(WaitUntil waitUntil, string apiKeyName, NginxDeploymentApiKeyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _nginxDeploymentApiKeyApiKeysRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, content, cancellationToken);
                var uri = _nginxDeploymentApiKeyApiKeysRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, content);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NginxArmOperation<NginxDeploymentApiKeyResource>(Response.FromValue(new NginxDeploymentApiKeyResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified API Key of the given Nginx deployment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> is null. </exception>
        public virtual async Task<Response<NginxDeploymentApiKeyResource>> GetAsync(string apiKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.Get");
            scope.Start();
            try
            {
                var response = await _nginxDeploymentApiKeyApiKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NginxDeploymentApiKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified API Key of the given Nginx deployment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> is null. </exception>
        public virtual Response<NginxDeploymentApiKeyResource> Get(string apiKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.Get");
            scope.Start();
            try
            {
                var response = _nginxDeploymentApiKeyApiKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NginxDeploymentApiKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all API Keys of the given Nginx deployment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NginxDeploymentApiKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NginxDeploymentApiKeyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nginxDeploymentApiKeyApiKeysRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nginxDeploymentApiKeyApiKeysRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NginxDeploymentApiKeyResource(Client, NginxDeploymentApiKeyData.DeserializeNginxDeploymentApiKeyData(e)), _nginxDeploymentApiKeyApiKeysClientDiagnostics, Pipeline, "NginxDeploymentApiKeyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all API Keys of the given Nginx deployment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NginxDeploymentApiKeyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NginxDeploymentApiKeyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _nginxDeploymentApiKeyApiKeysRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _nginxDeploymentApiKeyApiKeysRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NginxDeploymentApiKeyResource(Client, NginxDeploymentApiKeyData.DeserializeNginxDeploymentApiKeyData(e)), _nginxDeploymentApiKeyApiKeysClientDiagnostics, Pipeline, "NginxDeploymentApiKeyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _nginxDeploymentApiKeyApiKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> is null. </exception>
        public virtual Response<bool> Exists(string apiKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.Exists");
            scope.Start();
            try
            {
                var response = _nginxDeploymentApiKeyApiKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> is null. </exception>
        public virtual async Task<NullableResponse<NginxDeploymentApiKeyResource>> GetIfExistsAsync(string apiKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _nginxDeploymentApiKeyApiKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NginxDeploymentApiKeyResource>(response.GetRawResponse());
                return Response.FromValue(new NginxDeploymentApiKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Nginx.NginxPlus/nginxDeployments/{deploymentName}/apiKeys/{apiKeyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiKeys_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentApiKeyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiKeyName"> The resource name of the API key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiKeyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKeyName"/> is null. </exception>
        public virtual NullableResponse<NginxDeploymentApiKeyResource> GetIfExists(string apiKeyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiKeyName, nameof(apiKeyName));

            using var scope = _nginxDeploymentApiKeyApiKeysClientDiagnostics.CreateScope("NginxDeploymentApiKeyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _nginxDeploymentApiKeyApiKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, apiKeyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NginxDeploymentApiKeyResource>(response.GetRawResponse());
                return Response.FromValue(new NginxDeploymentApiKeyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NginxDeploymentApiKeyResource> IEnumerable<NginxDeploymentApiKeyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NginxDeploymentApiKeyResource> IAsyncEnumerable<NginxDeploymentApiKeyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
