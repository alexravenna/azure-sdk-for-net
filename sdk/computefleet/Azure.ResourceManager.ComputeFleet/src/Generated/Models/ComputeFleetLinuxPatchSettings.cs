// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Specifies settings related to VM Guest Patching on Linux. </summary>
    public partial class ComputeFleetLinuxPatchSettings
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

        /// <summary> Initializes a new instance of <see cref="ComputeFleetLinuxPatchSettings"/>. </summary>
        public ComputeFleetLinuxPatchSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetLinuxPatchSettings"/>. </summary>
        /// <param name="patchMode">
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - The
        /// virtual machine's default patching configuration is used. &lt;br /&gt;&lt;br /&gt;
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </param>
        /// <param name="assessmentMode">
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. &lt;br /&gt;&lt;br /&gt;
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </param>
        /// <param name="automaticByPlatformSettings">
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Linux.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetLinuxPatchSettings(ComputeFleetLinuxVmGuestPatchMode? patchMode, ComputeFleetLinuxPatchAssessmentMode? assessmentMode, ComputeFleetLinuxVmGuestPatchAutomaticByPlatformSettings automaticByPlatformSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PatchMode = patchMode;
            AssessmentMode = assessmentMode;
            AutomaticByPlatformSettings = automaticByPlatformSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - The
        /// virtual machine's default patching configuration is used. &lt;br /&gt;&lt;br /&gt;
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        public ComputeFleetLinuxVmGuestPatchMode? PatchMode { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. &lt;br /&gt;&lt;br /&gt;
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        public ComputeFleetLinuxPatchAssessmentMode? AssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Linux.
        /// </summary>
        public ComputeFleetLinuxVmGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSettings { get; set; }
    }
}
