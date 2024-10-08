// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile. </summary>
    internal partial class ManagedClusterVerticalPodAutoscaler
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterVerticalPodAutoscaler"/>. </summary>
        /// <param name="isVpaEnabled"> Whether to enable VPA. Default value is false. </param>
        public ManagedClusterVerticalPodAutoscaler(bool isVpaEnabled)
        {
            IsVpaEnabled = isVpaEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterVerticalPodAutoscaler"/>. </summary>
        /// <param name="isVpaEnabled"> Whether to enable VPA. Default value is false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterVerticalPodAutoscaler(bool isVpaEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsVpaEnabled = isVpaEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterVerticalPodAutoscaler"/> for deserialization. </summary>
        internal ManagedClusterVerticalPodAutoscaler()
        {
        }

        /// <summary> Whether to enable VPA. Default value is false. </summary>
        [WirePath("enabled")]
        public bool IsVpaEnabled { get; set; }
    }
}
