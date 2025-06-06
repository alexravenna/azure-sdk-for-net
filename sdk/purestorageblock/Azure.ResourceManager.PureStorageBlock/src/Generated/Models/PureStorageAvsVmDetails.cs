// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    /// <summary> AVS VM details. </summary>
    public partial class PureStorageAvsVmDetails
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

        /// <summary> Initializes a new instance of <see cref="PureStorageAvsVmDetails"/>. </summary>
        /// <param name="vmId"> ID of the AVS VM using this set of volumes. </param>
        /// <param name="vmName"> Name of the VMware VM using this set of volumes. </param>
        /// <param name="vmType"> Type of the VMware VM using this set of volumes. </param>
        /// <param name="avsVmInternalId"> Pure Storage's internal ID for this AVS VM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmId"/>, <paramref name="vmName"/> or <paramref name="avsVmInternalId"/> is null. </exception>
        internal PureStorageAvsVmDetails(string vmId, string vmName, PureStorageAvsVmType vmType, string avsVmInternalId)
        {
            Argument.AssertNotNull(vmId, nameof(vmId));
            Argument.AssertNotNull(vmName, nameof(vmName));
            Argument.AssertNotNull(avsVmInternalId, nameof(avsVmInternalId));

            VmId = vmId;
            VmName = vmName;
            VmType = vmType;
            AvsVmInternalId = avsVmInternalId;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageAvsVmDetails"/>. </summary>
        /// <param name="vmId"> ID of the AVS VM using this set of volumes. </param>
        /// <param name="vmName"> Name of the VMware VM using this set of volumes. </param>
        /// <param name="vmType"> Type of the VMware VM using this set of volumes. </param>
        /// <param name="avsVmInternalId"> Pure Storage's internal ID for this AVS VM. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PureStorageAvsVmDetails(string vmId, string vmName, PureStorageAvsVmType vmType, string avsVmInternalId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmId = vmId;
            VmName = vmName;
            VmType = vmType;
            AvsVmInternalId = avsVmInternalId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageAvsVmDetails"/> for deserialization. </summary>
        internal PureStorageAvsVmDetails()
        {
        }

        /// <summary> ID of the AVS VM using this set of volumes. </summary>
        public string VmId { get; }
        /// <summary> Name of the VMware VM using this set of volumes. </summary>
        public string VmName { get; }
        /// <summary> Type of the VMware VM using this set of volumes. </summary>
        public PureStorageAvsVmType VmType { get; }
        /// <summary> Pure Storage's internal ID for this AVS VM. </summary>
        public string AvsVmInternalId { get; }
    }
}
