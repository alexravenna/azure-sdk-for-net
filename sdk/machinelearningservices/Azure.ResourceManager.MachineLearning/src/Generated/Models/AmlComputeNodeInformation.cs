// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Compute node information related to a AmlCompute. </summary>
    public partial class AmlComputeNodeInformation
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AmlComputeNodeInformation"/>. </summary>
        internal AmlComputeNodeInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AmlComputeNodeInformation"/>. </summary>
        /// <param name="nodeId"> ID of the compute node. </param>
        /// <param name="privateIPAddress"> Private IP address of the compute node. </param>
        /// <param name="publicIPAddress"> Public IP address of the compute node. </param>
        /// <param name="port"> SSH port number of the node. </param>
        /// <param name="nodeState"> State of the compute node. Values are idle, running, preparing, unusable, leaving and preempted. </param>
        /// <param name="runId"> ID of the Experiment running on the node, if any else null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlComputeNodeInformation(string nodeId, IPAddress privateIPAddress, IPAddress publicIPAddress, int? port, MachineLearningNodeState? nodeState, string runId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NodeId = nodeId;
            PrivateIPAddress = privateIPAddress;
            PublicIPAddress = publicIPAddress;
            Port = port;
            NodeState = nodeState;
            RunId = runId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID of the compute node. </summary>
        [WirePath("nodeId")]
        public string NodeId { get; }
        /// <summary> Private IP address of the compute node. </summary>
        [WirePath("privateIpAddress")]
        public IPAddress PrivateIPAddress { get; }
        /// <summary> Public IP address of the compute node. </summary>
        [WirePath("publicIpAddress")]
        public IPAddress PublicIPAddress { get; }
        /// <summary> SSH port number of the node. </summary>
        [WirePath("port")]
        public int? Port { get; }
        /// <summary> State of the compute node. Values are idle, running, preparing, unusable, leaving and preempted. </summary>
        [WirePath("nodeState")]
        public MachineLearningNodeState? NodeState { get; }
        /// <summary> ID of the Experiment running on the node, if any else null. </summary>
        [WirePath("runId")]
        public string RunId { get; }
    }
}
