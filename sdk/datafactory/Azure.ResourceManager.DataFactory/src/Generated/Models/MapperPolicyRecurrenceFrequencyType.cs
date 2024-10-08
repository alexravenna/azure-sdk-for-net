// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Frequency of period in terms of 'Hour', 'Minute' or 'Second'. </summary>
    public readonly partial struct MapperPolicyRecurrenceFrequencyType : IEquatable<MapperPolicyRecurrenceFrequencyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapperPolicyRecurrenceFrequencyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapperPolicyRecurrenceFrequencyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HourValue = "Hour";
        private const string MinuteValue = "Minute";
        private const string SecondValue = "Second";

        /// <summary> Hour. </summary>
        public static MapperPolicyRecurrenceFrequencyType Hour { get; } = new MapperPolicyRecurrenceFrequencyType(HourValue);
        /// <summary> Minute. </summary>
        public static MapperPolicyRecurrenceFrequencyType Minute { get; } = new MapperPolicyRecurrenceFrequencyType(MinuteValue);
        /// <summary> Second. </summary>
        public static MapperPolicyRecurrenceFrequencyType Second { get; } = new MapperPolicyRecurrenceFrequencyType(SecondValue);
        /// <summary> Determines if two <see cref="MapperPolicyRecurrenceFrequencyType"/> values are the same. </summary>
        public static bool operator ==(MapperPolicyRecurrenceFrequencyType left, MapperPolicyRecurrenceFrequencyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapperPolicyRecurrenceFrequencyType"/> values are not the same. </summary>
        public static bool operator !=(MapperPolicyRecurrenceFrequencyType left, MapperPolicyRecurrenceFrequencyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MapperPolicyRecurrenceFrequencyType"/>. </summary>
        public static implicit operator MapperPolicyRecurrenceFrequencyType(string value) => new MapperPolicyRecurrenceFrequencyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapperPolicyRecurrenceFrequencyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapperPolicyRecurrenceFrequencyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
