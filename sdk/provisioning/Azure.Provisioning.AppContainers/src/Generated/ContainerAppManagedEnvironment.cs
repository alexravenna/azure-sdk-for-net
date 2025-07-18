// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.Net;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppManagedEnvironment.
/// </summary>
public partial class ContainerAppManagedEnvironment : ProvisionableResource
{
    /// <summary>
    /// Name of the Environment.
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
    /// Cluster configuration which enables the log daemon to export app logs
    /// to configured destination.
    /// </summary>
    public ContainerAppLogsConfiguration AppLogsConfiguration 
    {
        get { Initialize(); return _appLogsConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _appLogsConfiguration, value); }
    }
    private ContainerAppLogsConfiguration? _appLogsConfiguration;

    /// <summary>
    /// Custom domain configuration for the environment.
    /// </summary>
    public ContainerAppCustomDomainConfiguration CustomDomainConfiguration 
    {
        get { Initialize(); return _customDomainConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _customDomainConfiguration, value); }
    }
    private ContainerAppCustomDomainConfiguration? _customDomainConfiguration;

    /// <summary>
    /// Application Insights connection string used by Dapr to export Service
    /// to Service communication telemetry.
    /// </summary>
    public BicepValue<string> DaprAIConnectionString 
    {
        get { Initialize(); return _daprAIConnectionString!; }
        set { Initialize(); _daprAIConnectionString!.Assign(value); }
    }
    private BicepValue<string>? _daprAIConnectionString;

    /// <summary>
    /// Azure Monitor instrumentation key used by Dapr to export Service to
    /// Service communication telemetry.
    /// </summary>
    public BicepValue<string> DaprAIInstrumentationKey 
    {
        get { Initialize(); return _daprAIInstrumentationKey!; }
        set { Initialize(); _daprAIInstrumentationKey!.Assign(value); }
    }
    private BicepValue<string>? _daprAIInstrumentationKey;

    /// <summary>
    /// Managed identities for the Managed Environment to interact with other
    /// Azure services without maintaining any secrets or credentials in code.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// Name of the platform-managed resource group created for the Managed
    /// Environment to host infrastructure resources. If a subnet ID is
    /// provided, this resource group will be created in the same subscription
    /// as the subnet.
    /// </summary>
    public BicepValue<string> InfrastructureResourceGroup 
    {
        get { Initialize(); return _infrastructureResourceGroup!; }
        set { Initialize(); _infrastructureResourceGroup!.Assign(value); }
    }
    private BicepValue<string>? _infrastructureResourceGroup;

    /// <summary>
    /// Boolean indicating whether the peer traffic encryption is enabled.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Boolean indicating whether the mutual TLS authentication is enabled.
    /// </summary>
    public BicepValue<bool> IsMtlsEnabled 
    {
        get { Initialize(); return _isMtlsEnabled!; }
        set { Initialize(); _isMtlsEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isMtlsEnabled;

    /// <summary>
    /// Whether or not this Managed Environment is zone-redundant.
    /// </summary>
    public BicepValue<bool> IsZoneRedundant 
    {
        get { Initialize(); return _isZoneRedundant!; }
        set { Initialize(); _isZoneRedundant!.Assign(value); }
    }
    private BicepValue<bool>? _isZoneRedundant;

    /// <summary>
    /// Kind of the Environment.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

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
    /// Vnet configuration for the environment.
    /// </summary>
    public ContainerAppVnetConfiguration VnetConfiguration 
    {
        get { Initialize(); return _vnetConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _vnetConfiguration, value); }
    }
    private ContainerAppVnetConfiguration? _vnetConfiguration;

    /// <summary>
    /// Workload profiles configured for the Managed Environment.
    /// </summary>
    public BicepList<ContainerAppWorkloadProfile> WorkloadProfiles 
    {
        get { Initialize(); return _workloadProfiles!; }
        set { Initialize(); _workloadProfiles!.Assign(value); }
    }
    private BicepList<ContainerAppWorkloadProfile>? _workloadProfiles;

    /// <summary>
    /// The version of Dapr.
    /// </summary>
    public BicepValue<string> DaprVersion 
    {
        get { Initialize(); return _daprVersion!; }
    }
    private BicepValue<string>? _daprVersion;

    /// <summary>
    /// Default Domain Name for the cluster.
    /// </summary>
    public BicepValue<string> DefaultDomain 
    {
        get { Initialize(); return _defaultDomain!; }
    }
    private BicepValue<string>? _defaultDomain;

    /// <summary>
    /// Any errors that occurred during deployment or deployment validation.
    /// </summary>
    public BicepValue<string> DeploymentErrors 
    {
        get { Initialize(); return _deploymentErrors!; }
    }
    private BicepValue<string>? _deploymentErrors;

    /// <summary>
    /// The endpoint of the eventstream of the Environment.
    /// </summary>
    public BicepValue<string> EventStreamEndpoint 
    {
        get { Initialize(); return _eventStreamEndpoint!; }
    }
    private BicepValue<string>? _eventStreamEndpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The version of Keda.
    /// </summary>
    public BicepValue<string> KedaVersion 
    {
        get { Initialize(); return _kedaVersion!; }
    }
    private BicepValue<string>? _kedaVersion;

    /// <summary>
    /// Provisioning state of the Environment.
    /// </summary>
    public BicepValue<ContainerAppEnvironmentProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ContainerAppEnvironmentProvisioningState>? _provisioningState;

    /// <summary>
    /// Static IP of the Environment.
    /// </summary>
    public BicepValue<IPAddress> StaticIP 
    {
        get { Initialize(); return _staticIP!; }
    }
    private BicepValue<IPAddress>? _staticIP;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new ContainerAppManagedEnvironment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerAppManagedEnvironment
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironment.</param>
    public ContainerAppManagedEnvironment(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.App/managedEnvironments", resourceVersion ?? "2025-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppManagedEnvironment.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _appLogsConfiguration = DefineModelProperty<ContainerAppLogsConfiguration>("AppLogsConfiguration", ["properties", "appLogsConfiguration"]);
        _customDomainConfiguration = DefineModelProperty<ContainerAppCustomDomainConfiguration>("CustomDomainConfiguration", ["properties", "customDomainConfiguration"]);
        _daprAIConnectionString = DefineProperty<string>("DaprAIConnectionString", ["properties", "daprAIConnectionString"]);
        _daprAIInstrumentationKey = DefineProperty<string>("DaprAIInstrumentationKey", ["properties", "daprAIInstrumentationKey"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _infrastructureResourceGroup = DefineProperty<string>("InfrastructureResourceGroup", ["properties", "infrastructureResourceGroup"]);
        _isEnabled = DefineProperty<bool>("IsEnabled", ["properties", "peerTrafficConfiguration", "encryption", "enabled"]);
        _isMtlsEnabled = DefineProperty<bool>("IsMtlsEnabled", ["properties", "peerAuthentication", "mtls", "enabled"]);
        _isZoneRedundant = DefineProperty<bool>("IsZoneRedundant", ["properties", "zoneRedundant"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _vnetConfiguration = DefineModelProperty<ContainerAppVnetConfiguration>("VnetConfiguration", ["properties", "vnetConfiguration"]);
        _workloadProfiles = DefineListProperty<ContainerAppWorkloadProfile>("WorkloadProfiles", ["properties", "workloadProfiles"]);
        _daprVersion = DefineProperty<string>("DaprVersion", ["properties", "daprConfiguration", "version"], isOutput: true);
        _defaultDomain = DefineProperty<string>("DefaultDomain", ["properties", "defaultDomain"], isOutput: true);
        _deploymentErrors = DefineProperty<string>("DeploymentErrors", ["properties", "deploymentErrors"], isOutput: true);
        _eventStreamEndpoint = DefineProperty<string>("EventStreamEndpoint", ["properties", "eventStreamEndpoint"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _kedaVersion = DefineProperty<string>("KedaVersion", ["properties", "kedaConfiguration", "version"], isOutput: true);
        _provisioningState = DefineProperty<ContainerAppEnvironmentProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _staticIP = DefineProperty<IPAddress>("StaticIP", ["properties", "staticIp"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ContainerAppManagedEnvironment resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2025-01-01.
        /// </summary>
        public static readonly string V2025_01_01 = "2025-01-01";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerAppManagedEnvironment.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerAppManagedEnvironment
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironment.</param>
    /// <returns>The existing ContainerAppManagedEnvironment resource.</returns>
    public static ContainerAppManagedEnvironment FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this ContainerAppManagedEnvironment.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(AppContainersBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{AppContainersBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// ContainerAppManagedEnvironment.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(AppContainersBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{AppContainersBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
