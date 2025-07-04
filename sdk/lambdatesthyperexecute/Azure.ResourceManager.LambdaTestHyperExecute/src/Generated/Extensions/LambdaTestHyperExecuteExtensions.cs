// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.LambdaTestHyperExecute.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LambdaTestHyperExecute
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.LambdaTestHyperExecute. </summary>
    public static partial class LambdaTestHyperExecuteExtensions
    {
        private static MockableLambdaTestHyperExecuteArmClient GetMockableLambdaTestHyperExecuteArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableLambdaTestHyperExecuteArmClient(client0));
        }

        private static MockableLambdaTestHyperExecuteResourceGroupResource GetMockableLambdaTestHyperExecuteResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLambdaTestHyperExecuteResourceGroupResource(client, resource.Id));
        }

        private static MockableLambdaTestHyperExecuteSubscriptionResource GetMockableLambdaTestHyperExecuteSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLambdaTestHyperExecuteSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="LambdaTestHyperExecuteOrganizationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LambdaTestHyperExecuteOrganizationResource.CreateResourceIdentifier" /> to create a <see cref="LambdaTestHyperExecuteOrganizationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLambdaTestHyperExecuteArmClient.GetLambdaTestHyperExecuteOrganizationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LambdaTestHyperExecuteOrganizationResource"/> object. </returns>
        public static LambdaTestHyperExecuteOrganizationResource GetLambdaTestHyperExecuteOrganizationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLambdaTestHyperExecuteArmClient(client).GetLambdaTestHyperExecuteOrganizationResource(id);
        }

        /// <summary>
        /// Gets a collection of LambdaTestHyperExecuteOrganizationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLambdaTestHyperExecuteResourceGroupResource.GetLambdaTestHyperExecuteOrganizations()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of LambdaTestHyperExecuteOrganizationResources and their operations over a LambdaTestHyperExecuteOrganizationResource. </returns>
        public static LambdaTestHyperExecuteOrganizationCollection GetLambdaTestHyperExecuteOrganizations(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLambdaTestHyperExecuteResourceGroupResource(resourceGroupResource).GetLambdaTestHyperExecuteOrganizations();
        }

        /// <summary>
        /// Get a OrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/LambdaTest.HyperExecute/organizations/{organizationname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LambdaTestHyperExecuteOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLambdaTestHyperExecuteResourceGroupResource.GetLambdaTestHyperExecuteOrganizationAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationname"> Name of the Organization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="organizationname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationname"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LambdaTestHyperExecuteOrganizationResource>> GetLambdaTestHyperExecuteOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableLambdaTestHyperExecuteResourceGroupResource(resourceGroupResource).GetLambdaTestHyperExecuteOrganizationAsync(organizationname, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a OrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/LambdaTest.HyperExecute/organizations/{organizationname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LambdaTestHyperExecuteOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLambdaTestHyperExecuteResourceGroupResource.GetLambdaTestHyperExecuteOrganization(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationname"> Name of the Organization resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="organizationname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationname"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LambdaTestHyperExecuteOrganizationResource> GetLambdaTestHyperExecuteOrganization(this ResourceGroupResource resourceGroupResource, string organizationname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLambdaTestHyperExecuteResourceGroupResource(resourceGroupResource).GetLambdaTestHyperExecuteOrganization(organizationname, cancellationToken);
        }

        /// <summary>
        /// List OrganizationResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/LambdaTest.HyperExecute/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LambdaTestHyperExecuteOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLambdaTestHyperExecuteSubscriptionResource.GetLambdaTestHyperExecuteOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LambdaTestHyperExecuteOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LambdaTestHyperExecuteOrganizationResource> GetLambdaTestHyperExecuteOrganizationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLambdaTestHyperExecuteSubscriptionResource(subscriptionResource).GetLambdaTestHyperExecuteOrganizationsAsync(cancellationToken);
        }

        /// <summary>
        /// List OrganizationResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/LambdaTest.HyperExecute/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OrganizationResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LambdaTestHyperExecuteOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLambdaTestHyperExecuteSubscriptionResource.GetLambdaTestHyperExecuteOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LambdaTestHyperExecuteOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LambdaTestHyperExecuteOrganizationResource> GetLambdaTestHyperExecuteOrganizations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLambdaTestHyperExecuteSubscriptionResource(subscriptionResource).GetLambdaTestHyperExecuteOrganizations(cancellationToken);
        }
    }
}
