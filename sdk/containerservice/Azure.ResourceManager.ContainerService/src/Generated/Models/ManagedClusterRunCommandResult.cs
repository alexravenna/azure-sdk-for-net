// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> run command result. </summary>
    public partial class ManagedClusterRunCommandResult
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterRunCommandResult"/>. </summary>
        internal ManagedClusterRunCommandResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterRunCommandResult"/>. </summary>
        /// <param name="id"> The command id. </param>
        /// <param name="provisioningState"> provisioning State. </param>
        /// <param name="exitCode"> The exit code of the command. </param>
        /// <param name="startedOn"> The time when the command started. </param>
        /// <param name="finishedOn"> The time when the command finished. </param>
        /// <param name="logs"> The command output. </param>
        /// <param name="reason"> An explanation of why provisioningState is set to failed (if so). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterRunCommandResult(string id, string provisioningState, int? exitCode, DateTimeOffset? startedOn, DateTimeOffset? finishedOn, string logs, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ProvisioningState = provisioningState;
            ExitCode = exitCode;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
            Logs = logs;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The command id. </summary>
        [WirePath("id")]
        public string Id { get; }
        /// <summary> provisioning State. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
        /// <summary> The exit code of the command. </summary>
        [WirePath("properties.exitCode")]
        public int? ExitCode { get; }
        /// <summary> The time when the command started. </summary>
        [WirePath("properties.startedAt")]
        public DateTimeOffset? StartedOn { get; }
        /// <summary> The time when the command finished. </summary>
        [WirePath("properties.finishedAt")]
        public DateTimeOffset? FinishedOn { get; }
        /// <summary> The command output. </summary>
        [WirePath("properties.logs")]
        public string Logs { get; }
        /// <summary> An explanation of why provisioningState is set to failed (if so). </summary>
        [WirePath("properties.reason")]
        public string Reason { get; }
    }
}
