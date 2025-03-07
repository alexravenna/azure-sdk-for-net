// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DevOpsInfrastructure.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevOpsInfrastructure
{
    /// <summary>
    /// A Class representing a DevOpsPool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DevOpsPoolResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDevOpsPoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetDevOpsPool method.
    /// </summary>
    public partial class DevOpsPoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DevOpsPoolResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="poolName"> The poolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string poolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _devOpsPoolPoolsClientDiagnostics;
        private readonly PoolsRestOperations _devOpsPoolPoolsRestClient;
        private readonly ClientDiagnostics _resourceDetailsClientDiagnostics;
        private readonly ResourceDetailsRestOperations _resourceDetailsRestClient;
        private readonly DevOpsPoolData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevOpsInfrastructure/pools";

        /// <summary> Initializes a new instance of the <see cref="DevOpsPoolResource"/> class for mocking. </summary>
        protected DevOpsPoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevOpsPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DevOpsPoolResource(ArmClient client, DevOpsPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DevOpsPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DevOpsPoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devOpsPoolPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevOpsInfrastructure", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string devOpsPoolPoolsApiVersion);
            _devOpsPoolPoolsRestClient = new PoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devOpsPoolPoolsApiVersion);
            _resourceDetailsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevOpsInfrastructure", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _resourceDetailsRestClient = new ResourceDetailsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DevOpsPoolData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DevOpsPoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.Get");
            scope.Start();
            try
            {
                var response = await _devOpsPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevOpsPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DevOpsPoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.Get");
            scope.Start();
            try
            {
                var response = _devOpsPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevOpsPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.Delete");
            scope.Start();
            try
            {
                var response = await _devOpsPoolPoolsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DevOpsInfrastructureArmOperation(_devOpsPoolPoolsClientDiagnostics, Pipeline, _devOpsPoolPoolsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.Delete");
            scope.Start();
            try
            {
                var response = _devOpsPoolPoolsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new DevOpsInfrastructureArmOperation(_devOpsPoolPoolsClientDiagnostics, Pipeline, _devOpsPoolPoolsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<DevOpsPoolResource>> UpdateAsync(WaitUntil waitUntil, DevOpsPoolPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.Update");
            scope.Start();
            try
            {
                var response = await _devOpsPoolPoolsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new DevOpsInfrastructureArmOperation<DevOpsPoolResource>(new DevOpsPoolOperationSource(Client), _devOpsPoolPoolsClientDiagnostics, Pipeline, _devOpsPoolPoolsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<DevOpsPoolResource> Update(WaitUntil waitUntil, DevOpsPoolPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.Update");
            scope.Start();
            try
            {
                var response = _devOpsPoolPoolsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new DevOpsInfrastructureArmOperation<DevOpsPoolResource>(new DevOpsPoolOperationSource(Client), _devOpsPoolPoolsClientDiagnostics, Pipeline, _devOpsPoolPoolsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// List ResourceDetailsObject resources by Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}/resources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceDetailsObject_ListByPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevOpsResourceDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevOpsResourceDetails> GetResourceDetailsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceDetailsRestClient.CreateListByPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceDetailsRestClient.CreateListByPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => DevOpsResourceDetails.DeserializeDevOpsResourceDetails(e), _resourceDetailsClientDiagnostics, Pipeline, "DevOpsPoolResource.GetResourceDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ResourceDetailsObject resources by Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}/resources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceDetailsObject_ListByPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevOpsResourceDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevOpsResourceDetails> GetResourceDetails(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceDetailsRestClient.CreateListByPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceDetailsRestClient.CreateListByPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => DevOpsResourceDetails.DeserializeDevOpsResourceDetails(e), _resourceDetailsClientDiagnostics, Pipeline, "DevOpsPoolResource.GetResourceDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<DevOpsPoolResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _devOpsPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new DevOpsPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new DevOpsPoolPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DevOpsPoolResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _devOpsPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new DevOpsPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new DevOpsPoolPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<DevOpsPoolResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _devOpsPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new DevOpsPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new DevOpsPoolPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DevOpsPoolResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _devOpsPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new DevOpsPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new DevOpsPoolPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<DevOpsPoolResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _devOpsPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new DevOpsPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new DevOpsPoolPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DevOpsPoolResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _devOpsPoolPoolsClientDiagnostics.CreateScope("DevOpsPoolResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _devOpsPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new DevOpsPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new DevOpsPoolPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
