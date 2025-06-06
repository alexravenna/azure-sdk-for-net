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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGuardProxyResource"/> and their operations.
    /// Each <see cref="ResourceGuardProxyResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="ResourceGuardProxyCollection"/> instance call the GetResourceGuardProxies method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ResourceGuardProxyCollection : ArmCollection, IEnumerable<ResourceGuardProxyResource>, IAsyncEnumerable<ResourceGuardProxyResource>
    {
        private readonly ClientDiagnostics _resourceGuardProxyClientDiagnostics;
        private readonly ResourceGuardProxyRestOperations _resourceGuardProxyRestClient;
        private readonly string _vaultName;

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardProxyCollection"/> class for mocking. </summary>
        protected ResourceGuardProxyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGuardProxyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        internal ResourceGuardProxyCollection(ArmClient client, ResourceIdentifier id, string vaultName) : base(client, id)
        {
            _vaultName = vaultName;
            _resourceGuardProxyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ResourceGuardProxyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGuardProxyResource.ResourceType, out string resourceGuardProxyApiVersion);
            _resourceGuardProxyRestClient = new ResourceGuardProxyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGuardProxyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add or Update ResourceGuardProxy under vault
        /// Secures vault critical operations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceGuardProxyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceGuardProxyName, ResourceGuardProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, data, cancellationToken).ConfigureAwait(false);
                var uri = _resourceGuardProxyRestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new RecoveryServicesBackupArmOperation<ResourceGuardProxyResource>(Response.FromValue(new ResourceGuardProxyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Add or Update ResourceGuardProxy under vault
        /// Secures vault critical operations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourceGuardProxyResource> CreateOrUpdate(WaitUntil waitUntil, string resourceGuardProxyName, ResourceGuardProxyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, data, cancellationToken);
                var uri = _resourceGuardProxyRestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new RecoveryServicesBackupArmOperation<ResourceGuardProxyResource>(Response.FromValue(new ResourceGuardProxyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Returns ResourceGuardProxy under vault and with the name referenced in request
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual async Task<Response<ResourceGuardProxyResource>> GetAsync(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns ResourceGuardProxy under vault and with the name referenced in request
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual Response<ResourceGuardProxyResource> Get(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the ResourceGuardProxies under vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGuardProxyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGuardProxyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGuardProxyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGuardProxyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourceGuardProxyResource(Client, ResourceGuardProxyData.DeserializeResourceGuardProxyData(e)), _resourceGuardProxyClientDiagnostics, Pipeline, "ResourceGuardProxyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the ResourceGuardProxies under vault
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGuardProxyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGuardProxyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGuardProxyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _vaultName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGuardProxyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _vaultName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourceGuardProxyResource(Client, ResourceGuardProxyData.DeserializeResourceGuardProxyData(e)), _resourceGuardProxyClientDiagnostics, Pipeline, "ResourceGuardProxyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceGuardProxyResource>> GetIfExistsAsync(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceGuardProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGuardProxyResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardProxyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupResourceGuardProxies/{resourceGuardProxyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceGuardProxy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceGuardProxyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGuardProxyName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGuardProxyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardProxyName"/> is null. </exception>
        public virtual NullableResponse<ResourceGuardProxyResource> GetIfExists(string resourceGuardProxyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGuardProxyName, nameof(resourceGuardProxyName));

            using var scope = _resourceGuardProxyClientDiagnostics.CreateScope("ResourceGuardProxyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceGuardProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _vaultName, resourceGuardProxyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGuardProxyResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGuardProxyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGuardProxyResource> IEnumerable<ResourceGuardProxyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGuardProxyResource> IAsyncEnumerable<ResourceGuardProxyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
