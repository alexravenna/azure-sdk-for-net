// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Provision states for confluent RP. </summary>
    public readonly partial struct ConfluentProvisionState : IEquatable<ConfluentProvisionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfluentProvisionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfluentProvisionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletedValue = "Deleted";
        private const string NotSpecifiedValue = "NotSpecified";

        /// <summary> Accepted. </summary>
        public static ConfluentProvisionState Accepted { get; } = new ConfluentProvisionState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static ConfluentProvisionState Creating { get; } = new ConfluentProvisionState(CreatingValue);
        /// <summary> Updating. </summary>
        public static ConfluentProvisionState Updating { get; } = new ConfluentProvisionState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ConfluentProvisionState Deleting { get; } = new ConfluentProvisionState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static ConfluentProvisionState Succeeded { get; } = new ConfluentProvisionState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ConfluentProvisionState Failed { get; } = new ConfluentProvisionState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ConfluentProvisionState Canceled { get; } = new ConfluentProvisionState(CanceledValue);
        /// <summary> Deleted. </summary>
        public static ConfluentProvisionState Deleted { get; } = new ConfluentProvisionState(DeletedValue);
        /// <summary> NotSpecified. </summary>
        public static ConfluentProvisionState NotSpecified { get; } = new ConfluentProvisionState(NotSpecifiedValue);
        /// <summary> Determines if two <see cref="ConfluentProvisionState"/> values are the same. </summary>
        public static bool operator ==(ConfluentProvisionState left, ConfluentProvisionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfluentProvisionState"/> values are not the same. </summary>
        public static bool operator !=(ConfluentProvisionState left, ConfluentProvisionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConfluentProvisionState"/>. </summary>
        public static implicit operator ConfluentProvisionState(string value) => new ConfluentProvisionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfluentProvisionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfluentProvisionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
