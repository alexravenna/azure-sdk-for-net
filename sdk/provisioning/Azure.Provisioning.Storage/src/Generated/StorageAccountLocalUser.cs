// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Storage;

/// <summary>
/// StorageAccountLocalUser.
/// </summary>
public partial class StorageAccountLocalUser : ProvisionableResource
{
    /// <summary>
    /// The name of local user. The username must contain lowercase letters and
    /// numbers only. It must be unique only within the storage account.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Supplementary group membership. Only applicable for local users enabled
    /// for NFSv3 access.
    /// </summary>
    public BicepList<int> ExtendedGroups 
    {
        get { Initialize(); return _extendedGroups!; }
        set { Initialize(); _extendedGroups!.Assign(value); }
    }
    private BicepList<int>? _extendedGroups;

    /// <summary>
    /// An identifier for associating a group of users.
    /// </summary>
    public BicepValue<int> GroupId 
    {
        get { Initialize(); return _groupId!; }
        set { Initialize(); _groupId!.Assign(value); }
    }
    private BicepValue<int>? _groupId;

    /// <summary>
    /// Indicates whether shared key exists. Set it to false to remove existing
    /// shared key.
    /// </summary>
    public BicepValue<bool> HasSharedKey 
    {
        get { Initialize(); return _hasSharedKey!; }
        set { Initialize(); _hasSharedKey!.Assign(value); }
    }
    private BicepValue<bool>? _hasSharedKey;

    /// <summary>
    /// Indicates whether ssh key exists. Set it to false to remove existing
    /// SSH key.
    /// </summary>
    public BicepValue<bool> HasSshKey 
    {
        get { Initialize(); return _hasSshKey!; }
        set { Initialize(); _hasSshKey!.Assign(value); }
    }
    private BicepValue<bool>? _hasSshKey;

    /// <summary>
    /// Indicates whether ssh password exists. Set it to false to remove
    /// existing SSH password.
    /// </summary>
    public BicepValue<bool> HasSshPassword 
    {
        get { Initialize(); return _hasSshPassword!; }
        set { Initialize(); _hasSshPassword!.Assign(value); }
    }
    private BicepValue<bool>? _hasSshPassword;

    /// <summary>
    /// Optional, local user home directory.
    /// </summary>
    public BicepValue<string> HomeDirectory 
    {
        get { Initialize(); return _homeDirectory!; }
        set { Initialize(); _homeDirectory!.Assign(value); }
    }
    private BicepValue<string>? _homeDirectory;

    /// <summary>
    /// Indicates whether ACL authorization is allowed for this user. Set it to
    /// false to disallow using ACL authorization.
    /// </summary>
    public BicepValue<bool> IsAclAuthorizationAllowed 
    {
        get { Initialize(); return _isAclAuthorizationAllowed!; }
        set { Initialize(); _isAclAuthorizationAllowed!.Assign(value); }
    }
    private BicepValue<bool>? _isAclAuthorizationAllowed;

    /// <summary>
    /// Indicates if the local user is enabled for access with NFSv3 protocol.
    /// </summary>
    public BicepValue<bool> IsNfsV3Enabled 
    {
        get { Initialize(); return _isNfsV3Enabled!; }
        set { Initialize(); _isNfsV3Enabled!.Assign(value); }
    }
    private BicepValue<bool>? _isNfsV3Enabled;

    /// <summary>
    /// The permission scopes of the local user.
    /// </summary>
    public BicepList<StoragePermissionScope> PermissionScopes 
    {
        get { Initialize(); return _permissionScopes!; }
        set { Initialize(); _permissionScopes!.Assign(value); }
    }
    private BicepList<StoragePermissionScope>? _permissionScopes;

    /// <summary>
    /// Optional, local user ssh authorized keys for SFTP.
    /// </summary>
    public BicepList<StorageSshPublicKey> SshAuthorizedKeys 
    {
        get { Initialize(); return _sshAuthorizedKeys!; }
        set { Initialize(); _sshAuthorizedKeys!.Assign(value); }
    }
    private BicepList<StorageSshPublicKey>? _sshAuthorizedKeys;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// A unique Security Identifier that is generated by the server.
    /// </summary>
    public BicepValue<string> Sid 
    {
        get { Initialize(); return _sid!; }
    }
    private BicepValue<string>? _sid;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// A unique Identifier that is generated by the server.
    /// </summary>
    public BicepValue<int> UserId 
    {
        get { Initialize(); return _userId!; }
    }
    private BicepValue<int>? _userId;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<StorageAccount>? _parent;

    /// <summary>
    /// Creates a new StorageAccountLocalUser.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the StorageAccountLocalUser resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StorageAccountLocalUser.</param>
    public StorageAccountLocalUser(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Storage/storageAccounts/localUsers", resourceVersion ?? "2024-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of StorageAccountLocalUser.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _extendedGroups = DefineListProperty<int>("ExtendedGroups", ["properties", "extendedGroups"]);
        _groupId = DefineProperty<int>("GroupId", ["properties", "groupId"]);
        _hasSharedKey = DefineProperty<bool>("HasSharedKey", ["properties", "hasSharedKey"]);
        _hasSshKey = DefineProperty<bool>("HasSshKey", ["properties", "hasSshKey"]);
        _hasSshPassword = DefineProperty<bool>("HasSshPassword", ["properties", "hasSshPassword"]);
        _homeDirectory = DefineProperty<string>("HomeDirectory", ["properties", "homeDirectory"]);
        _isAclAuthorizationAllowed = DefineProperty<bool>("IsAclAuthorizationAllowed", ["properties", "allowAclAuthorization"]);
        _isNfsV3Enabled = DefineProperty<bool>("IsNfsV3Enabled", ["properties", "isNFSv3Enabled"]);
        _permissionScopes = DefineListProperty<StoragePermissionScope>("PermissionScopes", ["properties", "permissionScopes"]);
        _sshAuthorizedKeys = DefineListProperty<StorageSshPublicKey>("SshAuthorizedKeys", ["properties", "sshAuthorizedKeys"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _sid = DefineProperty<string>("Sid", ["properties", "sid"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _userId = DefineProperty<int>("UserId", ["properties", "userId"], isOutput: true);
        _parent = DefineResource<StorageAccount>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported StorageAccountLocalUser resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";

        /// <summary>
        /// 2016-01-01.
        /// </summary>
        public static readonly string V2016_01_01 = "2016-01-01";

        /// <summary>
        /// 2015-06-15.
        /// </summary>
        public static readonly string V2015_06_15 = "2015-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing StorageAccountLocalUser.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the StorageAccountLocalUser resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StorageAccountLocalUser.</param>
    /// <returns>The existing StorageAccountLocalUser resource.</returns>
    public static StorageAccountLocalUser FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get access keys for this StorageAccountLocalUser resource.
    /// </summary>
    /// <returns>The keys for this StorageAccountLocalUser resource.</returns>
    public LocalUserKeys GetKeys()
    {
        LocalUserKeys key = new();
        ((IBicepValue)key).Expression = new FunctionCallExpression(new MemberExpression(new IdentifierExpression(BicepIdentifier), "listKeys"));
        return key;
    }
}
