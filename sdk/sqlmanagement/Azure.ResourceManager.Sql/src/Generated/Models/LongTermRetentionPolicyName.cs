// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The LongTermRetentionPolicyName. </summary>
    public readonly partial struct LongTermRetentionPolicyName : IEquatable<LongTermRetentionPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LongTermRetentionPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LongTermRetentionPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static LongTermRetentionPolicyName Default { get; } = new LongTermRetentionPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="LongTermRetentionPolicyName"/> values are the same. </summary>
        public static bool operator ==(LongTermRetentionPolicyName left, LongTermRetentionPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LongTermRetentionPolicyName"/> values are not the same. </summary>
        public static bool operator !=(LongTermRetentionPolicyName left, LongTermRetentionPolicyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LongTermRetentionPolicyName"/>. </summary>
        public static implicit operator LongTermRetentionPolicyName(string value) => new LongTermRetentionPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LongTermRetentionPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LongTermRetentionPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
