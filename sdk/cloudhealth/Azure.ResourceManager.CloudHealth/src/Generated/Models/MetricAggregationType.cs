// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CloudHealth.Models
{
    /// <summary> Metric aggregation type. </summary>
    public readonly partial struct MetricAggregationType : IEquatable<MetricAggregationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricAggregationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricAggregationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AverageValue = "Average";
        private const string CountValue = "Count";
        private const string MinimumValue = "Minimum";
        private const string MaximumValue = "Maximum";
        private const string TotalValue = "Total";

        /// <summary> None. </summary>
        public static MetricAggregationType None { get; } = new MetricAggregationType(NoneValue);
        /// <summary> Average. </summary>
        public static MetricAggregationType Average { get; } = new MetricAggregationType(AverageValue);
        /// <summary> Count. </summary>
        public static MetricAggregationType Count { get; } = new MetricAggregationType(CountValue);
        /// <summary> Minimum. </summary>
        public static MetricAggregationType Minimum { get; } = new MetricAggregationType(MinimumValue);
        /// <summary> Maximum. </summary>
        public static MetricAggregationType Maximum { get; } = new MetricAggregationType(MaximumValue);
        /// <summary> Total. </summary>
        public static MetricAggregationType Total { get; } = new MetricAggregationType(TotalValue);
        /// <summary> Determines if two <see cref="MetricAggregationType"/> values are the same. </summary>
        public static bool operator ==(MetricAggregationType left, MetricAggregationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricAggregationType"/> values are not the same. </summary>
        public static bool operator !=(MetricAggregationType left, MetricAggregationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MetricAggregationType"/>. </summary>
        public static implicit operator MetricAggregationType(string value) => new MetricAggregationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricAggregationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricAggregationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
