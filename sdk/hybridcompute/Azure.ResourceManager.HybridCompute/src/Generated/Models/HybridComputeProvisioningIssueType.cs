// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Type of provisioning issue. </summary>
    public readonly partial struct HybridComputeProvisioningIssueType : IEquatable<HybridComputeProvisioningIssueType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridComputeProvisioningIssueType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridComputeProvisioningIssueType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MissingPerimeterConfigurationValue = "MissingPerimeterConfiguration";
        private const string MissingIdentityConfigurationValue = "MissingIdentityConfiguration";
        private const string ConfigurationPropagationFailureValue = "ConfigurationPropagationFailure";
        private const string OtherValue = "Other";

        /// <summary> Perimeter configuration is missing. </summary>
        public static HybridComputeProvisioningIssueType MissingPerimeterConfiguration { get; } = new HybridComputeProvisioningIssueType(MissingPerimeterConfigurationValue);
        /// <summary> Identity configuration is missing. </summary>
        public static HybridComputeProvisioningIssueType MissingIdentityConfiguration { get; } = new HybridComputeProvisioningIssueType(MissingIdentityConfigurationValue);
        /// <summary> Configuration failed to propagate. </summary>
        public static HybridComputeProvisioningIssueType ConfigurationPropagationFailure { get; } = new HybridComputeProvisioningIssueType(ConfigurationPropagationFailureValue);
        /// <summary> Other failure. </summary>
        public static HybridComputeProvisioningIssueType Other { get; } = new HybridComputeProvisioningIssueType(OtherValue);
        /// <summary> Determines if two <see cref="HybridComputeProvisioningIssueType"/> values are the same. </summary>
        public static bool operator ==(HybridComputeProvisioningIssueType left, HybridComputeProvisioningIssueType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridComputeProvisioningIssueType"/> values are not the same. </summary>
        public static bool operator !=(HybridComputeProvisioningIssueType left, HybridComputeProvisioningIssueType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridComputeProvisioningIssueType"/>. </summary>
        public static implicit operator HybridComputeProvisioningIssueType(string value) => new HybridComputeProvisioningIssueType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridComputeProvisioningIssueType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridComputeProvisioningIssueType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
