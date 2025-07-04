// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Search;

/// <summary>
/// SearchService.
/// </summary>
public partial class SearchService : ProvisionableResource
{
    /// <summary>
    /// The name of the Azure AI Search service to create or update. Search
    /// service names must only contain lowercase letters, digits or dashes,
    /// cannot use dash as the first two or last one characters, cannot
    /// contain consecutive dashes, and must be between 2 and 60 characters in
    /// length. Search service names must be globally unique since they are
    /// part of the service URI (https://&lt;name&gt;.search.windows.net). You
    /// cannot change the service name after the service is created.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// Defines the options for how the data plane API of a search service
    /// authenticates requests. This cannot be set if
    /// &apos;disableLocalAuth&apos; is set to true.
    /// </summary>
    public SearchAadAuthDataPlaneAuthOptions AuthOptions 
    {
        get { Initialize(); return _authOptions!; }
        set { Initialize(); AssignOrReplace(ref _authOptions, value); }
    }
    private SearchAadAuthDataPlaneAuthOptions? _authOptions;

    /// <summary>
    /// Configure this property to support the search service using either the
    /// default compute or Azure Confidential Compute.
    /// </summary>
    public BicepValue<SearchServiceComputeType> ComputeType 
    {
        get { Initialize(); return _computeType!; }
        set { Initialize(); _computeType!.Assign(value); }
    }
    private BicepValue<SearchServiceComputeType>? _computeType;

    /// <summary>
    /// A list of data exfiltration scenarios that are explicitly disallowed
    /// for the search service. Currently, the only supported value is
    /// &apos;All&apos; to disable all possible data export scenarios with
    /// more fine grained controls planned for the future.
    /// </summary>
    public BicepList<SearchDisabledDataExfiltrationOption> DisabledDataExfiltrationOptions 
    {
        get { Initialize(); return _disabledDataExfiltrationOptions!; }
        set { Initialize(); _disabledDataExfiltrationOptions!.Assign(value); }
    }
    private BicepList<SearchDisabledDataExfiltrationOption>? _disabledDataExfiltrationOptions;

    /// <summary>
    /// Specifies any policy regarding encryption of resources (such as
    /// indexes) using customer manager keys within a search service.
    /// </summary>
    public SearchEncryptionWithCmk EncryptionWithCmk 
    {
        get { Initialize(); return _encryptionWithCmk!; }
        set { Initialize(); AssignOrReplace(ref _encryptionWithCmk, value); }
    }
    private SearchEncryptionWithCmk? _encryptionWithCmk;

    /// <summary>
    /// The endpoint of the Azure AI Search service.
    /// </summary>
    public BicepValue<Uri> Endpoint 
    {
        get { Initialize(); return _endpoint!; }
        set { Initialize(); _endpoint!.Assign(value); }
    }
    private BicepValue<Uri>? _endpoint;

    /// <summary>
    /// Applicable only for the standard3 SKU. You can set this property to
    /// enable up to 3 high density partitions that allow up to 1000 indexes,
    /// which is much higher than the maximum indexes allowed for any other
    /// SKU. For the standard3 SKU, the value is either &apos;default&apos; or
    /// &apos;highDensity&apos;. For all other SKUs, this value must be
    /// &apos;default&apos;.
    /// </summary>
    public BicepValue<SearchServiceHostingMode> HostingMode 
    {
        get { Initialize(); return _hostingMode!; }
        set { Initialize(); _hostingMode!.Assign(value); }
    }
    private BicepValue<SearchServiceHostingMode>? _hostingMode;

    /// <summary>
    /// The identity of the resource.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// A list of IP restriction rules used for an IP firewall. Any IPs that do
    /// not match the rules are blocked by the firewall. These rules are only
    /// applied when the &apos;publicNetworkAccess&apos; of the search service
    /// is &apos;enabled&apos;.
    /// </summary>
    public BicepList<SearchServiceIPRule> IPRules 
    {
        get { Initialize(); return _iPRules!; }
        set { Initialize(); _iPRules!.Assign(value); }
    }
    private BicepList<SearchServiceIPRule>? _iPRules;

    /// <summary>
    /// When set to true, calls to the search service will not be permitted to
    /// utilize API keys for authentication. This cannot be set to true if
    /// &apos;dataPlaneAuthOptions&apos; are defined.
    /// </summary>
    public BicepValue<bool> IsLocalAuthDisabled 
    {
        get { Initialize(); return _isLocalAuthDisabled!; }
        set { Initialize(); _isLocalAuthDisabled!.Assign(value); }
    }
    private BicepValue<bool>? _isLocalAuthDisabled;

    /// <summary>
    /// Network specific rules that determine how the Azure AI Search service
    /// may be reached.
    /// </summary>
    public SearchServiceNetworkRuleSet NetworkRuleSet 
    {
        get { Initialize(); return _networkRuleSet!; }
        set { Initialize(); AssignOrReplace(ref _networkRuleSet, value); }
    }
    private SearchServiceNetworkRuleSet? _networkRuleSet;

    /// <summary>
    /// The number of partitions in the search service; if specified, it can be
    /// 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for
    /// standard SKUs. For &apos;standard3&apos; services with hostingMode set
    /// to &apos;highDensity&apos;, the allowed values are between 1 and 3.
    /// </summary>
    public BicepValue<int> PartitionCount 
    {
        get { Initialize(); return _partitionCount!; }
        set { Initialize(); _partitionCount!.Assign(value); }
    }
    private BicepValue<int>? _partitionCount;

    /// <summary>
    /// This value can be set to &apos;enabled&apos; to avoid breaking changes
    /// on existing customer resources and templates. If set to
    /// &apos;disabled&apos;, traffic over public interface is not allowed,
    /// and private endpoint connections would be the exclusive access method.
    /// </summary>
    public BicepValue<SearchServicePublicNetworkAccess> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<SearchServicePublicNetworkAccess>? _publicNetworkAccess;

    /// <summary>
    /// The number of replicas in the search service. If specified, it must be
    /// a value between 1 and 12 inclusive for standard SKUs or between 1 and
    /// 3 inclusive for basic SKU.
    /// </summary>
    public BicepValue<int> ReplicaCount 
    {
        get { Initialize(); return _replicaCount!; }
        set { Initialize(); _replicaCount!.Assign(value); }
    }
    private BicepValue<int>? _replicaCount;

    /// <summary>
    /// The SKU of the search service. Valid values include: &apos;free&apos;:
    /// Shared service. &apos;basic&apos;: Dedicated service with up to 3
    /// replicas. &apos;standard&apos;: Dedicated service with up to 12
    /// partitions and 12 replicas. &apos;standard2&apos;: Similar to
    /// standard, but with more capacity per search unit.
    /// &apos;standard3&apos;: The largest Standard offering with up to 12
    /// partitions and 12 replicas (or up to 3 partitions with more indexes if
    /// you also set the hostingMode property to &apos;highDensity&apos;).
    /// &apos;storage_optimized_l1&apos;: Supports 1TB per partition, up to 12
    /// partitions. &apos;storage_optimized_l2&apos;: Supports 2TB per
    /// partition, up to 12 partitions.&apos;.
    /// </summary>
    public BicepValue<SearchServiceSkuName> SearchSkuName 
    {
        get { Initialize(); return _searchSkuName!; }
        set { Initialize(); _searchSkuName!.Assign(value); }
    }
    private BicepValue<SearchServiceSkuName>? _searchSkuName;

    /// <summary>
    /// Sets options that control the availability of semantic search. This
    /// configuration is only possible for certain Azure AI Search SKUs in
    /// certain locations.
    /// </summary>
    public BicepValue<SearchSemanticSearch> SemanticSearch 
    {
        get { Initialize(); return _semanticSearch!; }
        set { Initialize(); _semanticSearch!.Assign(value); }
    }
    private BicepValue<SearchSemanticSearch>? _semanticSearch;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// A system generated property representing the service&apos;s etag that
    /// can be for optimistic concurrency control during updates.
    /// </summary>
    public BicepValue<ETag> ETag 
    {
        get { Initialize(); return _eTag!; }
    }
    private BicepValue<ETag>? _eTag;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Indicates whether or not the search service has an upgrade available.
    /// </summary>
    public BicepValue<bool> IsUpgradeAvailable 
    {
        get { Initialize(); return _isUpgradeAvailable!; }
    }
    private BicepValue<bool>? _isUpgradeAvailable;

    /// <summary>
    /// The list of private endpoint connections to the Azure AI Search service.
    /// </summary>
    public BicepList<SearchPrivateEndpointConnectionData> PrivateEndpointConnections 
    {
        get { Initialize(); return _privateEndpointConnections!; }
    }
    private BicepList<SearchPrivateEndpointConnectionData>? _privateEndpointConnections;

    /// <summary>
    /// The state of the last provisioning operation performed on the search
    /// service. Provisioning is an intermediate state that occurs while
    /// service capacity is being established. After capacity is set up,
    /// provisioningState changes to either &apos;Succeeded&apos; or
    /// &apos;Failed&apos;. Client applications can poll provisioning status
    /// (the recommended polling interval is from 30 seconds to one minute) by
    /// using the Get Search Service operation to see when an operation is
    /// completed. If you are using the free service, this value tends to come
    /// back as &apos;Succeeded&apos; directly in the call to Create search
    /// service. This is because the free service uses capacity that is
    /// already set up.
    /// </summary>
    public BicepValue<SearchServiceProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<SearchServiceProvisioningState>? _provisioningState;

    /// <summary>
    /// The date and time the search service was last upgraded. This field will
    /// be null until the service gets upgraded for the first time.
    /// </summary>
    public BicepValue<DateTimeOffset> ServiceUpgradeOn 
    {
        get { Initialize(); return _serviceUpgradeOn!; }
    }
    private BicepValue<DateTimeOffset>? _serviceUpgradeOn;

    /// <summary>
    /// The list of shared private link resources managed by the Azure AI
    /// Search service.
    /// </summary>
    public BicepList<SharedSearchServicePrivateLinkResourceData> SharedPrivateLinkResources 
    {
        get { Initialize(); return _sharedPrivateLinkResources!; }
    }
    private BicepList<SharedSearchServicePrivateLinkResourceData>? _sharedPrivateLinkResources;

    /// <summary>
    /// The status of the search service. Possible values include:
    /// &apos;running&apos;: The search service is running and no provisioning
    /// operations are underway. &apos;provisioning&apos;: The search service
    /// is being provisioned or scaled up or down. &apos;deleting&apos;: The
    /// search service is being deleted. &apos;degraded&apos;: The search
    /// service is degraded. This can occur when the underlying search units
    /// are not healthy. The search service is most likely operational, but
    /// performance might be slow and some requests might be dropped.
    /// &apos;disabled&apos;: The search service is disabled. In this state,
    /// the service will reject all API requests. &apos;error&apos;: The
    /// search service is in an error state. &apos;stopped&apos;: The search
    /// service is in a subscription that&apos;s disabled. If your service is
    /// in the degraded, disabled, or error states, it means the Azure AI
    /// Search team is actively investigating the underlying issue. Dedicated
    /// services in these states are still chargeable based on the number of
    /// search units provisioned.
    /// </summary>
    public BicepValue<SearchServiceStatus> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<SearchServiceStatus>? _status;

    /// <summary>
    /// The details of the search service status.
    /// </summary>
    public BicepValue<string> StatusDetails 
    {
        get { Initialize(); return _statusDetails!; }
    }
    private BicepValue<string>? _statusDetails;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new SearchService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SearchService resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SearchService.</param>
    public SearchService(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Search/searchServices", resourceVersion ?? "2023-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SearchService.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _authOptions = DefineModelProperty<SearchAadAuthDataPlaneAuthOptions>("AuthOptions", ["properties", "authOptions"]);
        _computeType = DefineProperty<SearchServiceComputeType>("ComputeType", ["properties", "computeType"]);
        _disabledDataExfiltrationOptions = DefineListProperty<SearchDisabledDataExfiltrationOption>("DisabledDataExfiltrationOptions", ["properties", "disabledDataExfiltrationOptions"]);
        _encryptionWithCmk = DefineModelProperty<SearchEncryptionWithCmk>("EncryptionWithCmk", ["properties", "encryptionWithCmk"]);
        _endpoint = DefineProperty<Uri>("Endpoint", ["properties", "endpoint"]);
        _hostingMode = DefineProperty<SearchServiceHostingMode>("HostingMode", ["properties", "hostingMode"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _iPRules = DefineListProperty<SearchServiceIPRule>("IPRules", ["properties", "networkRuleSet", "ipRules"]);
        _isLocalAuthDisabled = DefineProperty<bool>("IsLocalAuthDisabled", ["properties", "disableLocalAuth"]);
        _networkRuleSet = DefineModelProperty<SearchServiceNetworkRuleSet>("NetworkRuleSet", ["properties", "networkRuleSet"]);
        _partitionCount = DefineProperty<int>("PartitionCount", ["properties", "partitionCount"]);
        _publicNetworkAccess = DefineProperty<SearchServicePublicNetworkAccess>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _replicaCount = DefineProperty<int>("ReplicaCount", ["properties", "replicaCount"]);
        _searchSkuName = DefineProperty<SearchServiceSkuName>("SearchSkuName", ["sku", "name"]);
        _semanticSearch = DefineProperty<SearchSemanticSearch>("SemanticSearch", ["properties", "semanticSearch"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _eTag = DefineProperty<ETag>("ETag", ["properties", "eTag"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _isUpgradeAvailable = DefineProperty<bool>("IsUpgradeAvailable", ["properties", "upgradeAvailable"], isOutput: true);
        _privateEndpointConnections = DefineListProperty<SearchPrivateEndpointConnectionData>("PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = DefineProperty<SearchServiceProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _serviceUpgradeOn = DefineProperty<DateTimeOffset>("ServiceUpgradeOn", ["properties", "serviceUpgradeDate"], isOutput: true);
        _sharedPrivateLinkResources = DefineListProperty<SharedSearchServicePrivateLinkResourceData>("SharedPrivateLinkResources", ["properties", "sharedPrivateLinkResources"], isOutput: true);
        _status = DefineProperty<SearchServiceStatus>("Status", ["properties", "status"], isOutput: true);
        _statusDetails = DefineProperty<string>("StatusDetails", ["properties", "statusDetails"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported SearchService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-11-01.
        /// </summary>
        public static readonly string V2023_11_01 = "2023-11-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";

        /// <summary>
        /// 2020-03-13.
        /// </summary>
        public static readonly string V2020_03_13 = "2020-03-13";

        /// <summary>
        /// 2015-08-19.
        /// </summary>
        public static readonly string V2015_08_19 = "2015-08-19";

        /// <summary>
        /// 2015-02-28.
        /// </summary>
        public static readonly string V2015_02_28 = "2015-02-28";

        /// <summary>
        /// 2025-02-01-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2025_02_01_Preview = "2025-02-01-Preview";

        /// <summary>
        /// 2024-06-01-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2024_06_01_Preview = "2024-06-01-Preview";

        /// <summary>
        /// 2024-03-01-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2024_03_01_Preview = "2024-03-01-Preview";

        /// <summary>
        /// 2021-06-06-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2021_06_06_Preview = "2021-06-06-Preview";

        /// <summary>
        /// 2021-04-01-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2021_04_01_Preview = "2021-04-01-Preview";

        /// <summary>
        /// 2020-08-01-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2020_08_01_Preview = "2020-08-01-Preview";

        /// <summary>
        /// 2019-10-01-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2019_10_01_Preview = "2019-10-01-Preview";

        /// <summary>
        /// 2014-07-31-Preview.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly string V2014_07_31_Preview = "2014-07-31-Preview";
    }

    /// <summary>
    /// Creates a reference to an existing SearchService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SearchService resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SearchService.</param>
    /// <returns>The existing SearchService resource.</returns>
    public static SearchService FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this SearchService resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 2, maxLength: 60, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this SearchService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(SearchBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{SearchBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// SearchService.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(SearchBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{SearchBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
