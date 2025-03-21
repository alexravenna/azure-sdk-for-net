// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Data flow policy rule QoS policy. </summary>
    public partial class PccRuleQosPolicy : MobileNetworkQosPolicy
    {
        /// <summary> Initializes a new instance of <see cref="PccRuleQosPolicy"/>. </summary>
        /// <param name="maximumBitRate"> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maximumBitRate"/> is null. </exception>
        public PccRuleQosPolicy(Ambr maximumBitRate) : base(maximumBitRate)
        {
            Argument.AssertNotNull(maximumBitRate, nameof(maximumBitRate));
        }

        /// <summary> Initializes a new instance of <see cref="PccRuleQosPolicy"/>. </summary>
        /// <param name="fiveQi"> 5G QoS Flow Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition the 5QI values. </param>
        /// <param name="allocationAndRetentionPriorityLevel"> QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionCapability"> QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="preemptionVulnerability"> QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters. </param>
        /// <param name="maximumBitRate"> The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="guaranteedBitRate"> The guaranteed bit rate (GBR) for all service data flows that use this data flow policy rule. This is an optional setting. If you do not provide a value, there will be no GBR set for the data flow policy rule that uses this QoS definition. </param>
        internal PccRuleQosPolicy(int? fiveQi, int? allocationAndRetentionPriorityLevel, MobileNetworkPreemptionCapability? preemptionCapability, MobileNetworkPreemptionVulnerability? preemptionVulnerability, Ambr maximumBitRate, IDictionary<string, BinaryData> serializedAdditionalRawData, Ambr guaranteedBitRate) : base(fiveQi, allocationAndRetentionPriorityLevel, preemptionCapability, preemptionVulnerability, maximumBitRate, serializedAdditionalRawData)
        {
            GuaranteedBitRate = guaranteedBitRate;
        }

        /// <summary> Initializes a new instance of <see cref="PccRuleQosPolicy"/> for deserialization. </summary>
        internal PccRuleQosPolicy()
        {
        }

        /// <summary> The guaranteed bit rate (GBR) for all service data flows that use this data flow policy rule. This is an optional setting. If you do not provide a value, there will be no GBR set for the data flow policy rule that uses this QoS definition. </summary>
        [WirePath("guaranteedBitRate")]
        public Ambr GuaranteedBitRate { get; set; }
    }
}
