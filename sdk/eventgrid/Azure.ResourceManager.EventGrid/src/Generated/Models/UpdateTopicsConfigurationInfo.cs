// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the topics configuration info of a namespace. </summary>
    internal partial class UpdateTopicsConfigurationInfo
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

        /// <summary> Initializes a new instance of <see cref="UpdateTopicsConfigurationInfo"/>. </summary>
        public UpdateTopicsConfigurationInfo()
        {
            CustomDomains = new ChangeTrackingList<CustomDomainConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateTopicsConfigurationInfo"/>. </summary>
        /// <param name="customDomains"> Custom domain info for topics configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateTopicsConfigurationInfo(IList<CustomDomainConfiguration> customDomains, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomDomains = customDomains;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Custom domain info for topics configuration. </summary>
        [WirePath("customDomains")]
        public IList<CustomDomainConfiguration> CustomDomains { get; }
    }
}
