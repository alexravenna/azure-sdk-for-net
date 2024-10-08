// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the L3 network. </summary>
    public readonly partial struct L3NetworkProvisioningState : IEquatable<L3NetworkProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="L3NetworkProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public L3NetworkProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string AcceptedValue = "Accepted";

        /// <summary> Succeeded. </summary>
        public static L3NetworkProvisioningState Succeeded { get; } = new L3NetworkProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static L3NetworkProvisioningState Failed { get; } = new L3NetworkProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static L3NetworkProvisioningState Canceled { get; } = new L3NetworkProvisioningState(CanceledValue);
        /// <summary> Provisioning. </summary>
        public static L3NetworkProvisioningState Provisioning { get; } = new L3NetworkProvisioningState(ProvisioningValue);
        /// <summary> Accepted. </summary>
        public static L3NetworkProvisioningState Accepted { get; } = new L3NetworkProvisioningState(AcceptedValue);
        /// <summary> Determines if two <see cref="L3NetworkProvisioningState"/> values are the same. </summary>
        public static bool operator ==(L3NetworkProvisioningState left, L3NetworkProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="L3NetworkProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(L3NetworkProvisioningState left, L3NetworkProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="L3NetworkProvisioningState"/>. </summary>
        public static implicit operator L3NetworkProvisioningState(string value) => new L3NetworkProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is L3NetworkProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(L3NetworkProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
