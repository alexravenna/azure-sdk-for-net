// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The HciNodeRebootRequirement. </summary>
    public readonly partial struct HciNodeRebootRequirement : IEquatable<HciNodeRebootRequirement>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciNodeRebootRequirement"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciNodeRebootRequirement(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> Unknown. </summary>
        public static HciNodeRebootRequirement Unknown { get; } = new HciNodeRebootRequirement(UnknownValue);
        /// <summary> True. </summary>
        public static HciNodeRebootRequirement True { get; } = new HciNodeRebootRequirement(TrueValue);
        /// <summary> False. </summary>
        public static HciNodeRebootRequirement False { get; } = new HciNodeRebootRequirement(FalseValue);
        /// <summary> Determines if two <see cref="HciNodeRebootRequirement"/> values are the same. </summary>
        public static bool operator ==(HciNodeRebootRequirement left, HciNodeRebootRequirement right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciNodeRebootRequirement"/> values are not the same. </summary>
        public static bool operator !=(HciNodeRebootRequirement left, HciNodeRebootRequirement right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HciNodeRebootRequirement"/>. </summary>
        public static implicit operator HciNodeRebootRequirement(string value) => new HciNodeRebootRequirement(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciNodeRebootRequirement other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciNodeRebootRequirement other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
