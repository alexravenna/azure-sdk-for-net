// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> The type of endpoint. </summary>
    public readonly partial struct HybridConnectivityEndpointType : IEquatable<HybridConnectivityEndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridConnectivityEndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridConnectivityEndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";
        private const string CustomValue = "custom";

        /// <summary> default. </summary>
        public static HybridConnectivityEndpointType Default { get; } = new HybridConnectivityEndpointType(DefaultValue);
        /// <summary> custom. </summary>
        public static HybridConnectivityEndpointType Custom { get; } = new HybridConnectivityEndpointType(CustomValue);
        /// <summary> Determines if two <see cref="HybridConnectivityEndpointType"/> values are the same. </summary>
        public static bool operator ==(HybridConnectivityEndpointType left, HybridConnectivityEndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridConnectivityEndpointType"/> values are not the same. </summary>
        public static bool operator !=(HybridConnectivityEndpointType left, HybridConnectivityEndpointType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridConnectivityEndpointType"/>. </summary>
        public static implicit operator HybridConnectivityEndpointType(string value) => new HybridConnectivityEndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridConnectivityEndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridConnectivityEndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
