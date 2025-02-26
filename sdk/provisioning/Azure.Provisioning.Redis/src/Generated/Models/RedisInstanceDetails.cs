// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// Details of single instance of redis.
/// </summary>
public partial class RedisInstanceDetails : ProvisionableConstruct
{
    /// <summary>
    /// Redis instance SSL port.
    /// </summary>
    public BicepValue<int> SslPort 
    {
        get { Initialize(); return _sslPort!; }
    }
    private BicepValue<int>? _sslPort;

    /// <summary>
    /// If enableNonSslPort is true, provides Redis instance Non-SSL port.
    /// </summary>
    public BicepValue<int> NonSslPort 
    {
        get { Initialize(); return _nonSslPort!; }
    }
    private BicepValue<int>? _nonSslPort;

    /// <summary>
    /// If the Cache uses availability zones, specifies availability zone where
    /// this instance is located.
    /// </summary>
    public BicepValue<string> Zone 
    {
        get { Initialize(); return _zone!; }
    }
    private BicepValue<string>? _zone;

    /// <summary>
    /// If clustering is enabled, the Shard ID of Redis Instance.
    /// </summary>
    public BicepValue<int> ShardId 
    {
        get { Initialize(); return _shardId!; }
    }
    private BicepValue<int>? _shardId;

    /// <summary>
    /// Specifies whether the instance is a primary node.
    /// </summary>
    public BicepValue<bool> IsMaster 
    {
        get { Initialize(); return _isMaster!; }
    }
    private BicepValue<bool>? _isMaster;

    /// <summary>
    /// Specifies whether the instance is a primary node.
    /// </summary>
    public BicepValue<bool> IsPrimary 
    {
        get { Initialize(); return _isPrimary!; }
    }
    private BicepValue<bool>? _isPrimary;

    /// <summary>
    /// Creates a new RedisInstanceDetails.
    /// </summary>
    public RedisInstanceDetails()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of RedisInstanceDetails.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _sslPort = DefineProperty<int>("SslPort", ["sslPort"], isOutput: true);
        _nonSslPort = DefineProperty<int>("NonSslPort", ["nonSslPort"], isOutput: true);
        _zone = DefineProperty<string>("Zone", ["zone"], isOutput: true);
        _shardId = DefineProperty<int>("ShardId", ["shardId"], isOutput: true);
        _isMaster = DefineProperty<bool>("IsMaster", ["isMaster"], isOutput: true);
        _isPrimary = DefineProperty<bool>("IsPrimary", ["isPrimary"], isOutput: true);
    }
}
