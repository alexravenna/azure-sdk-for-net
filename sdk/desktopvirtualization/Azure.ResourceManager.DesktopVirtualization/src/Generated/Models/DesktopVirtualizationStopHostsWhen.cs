// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Specifies when to stop hosts during ramp down period. </summary>
    public readonly partial struct DesktopVirtualizationStopHostsWhen : IEquatable<DesktopVirtualizationStopHostsWhen>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DesktopVirtualizationStopHostsWhen"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DesktopVirtualizationStopHostsWhen(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ZeroSessionsValue = "ZeroSessions";
        private const string ZeroActiveSessionsValue = "ZeroActiveSessions";

        /// <summary> ZeroSessions. </summary>
        public static DesktopVirtualizationStopHostsWhen ZeroSessions { get; } = new DesktopVirtualizationStopHostsWhen(ZeroSessionsValue);
        /// <summary> ZeroActiveSessions. </summary>
        public static DesktopVirtualizationStopHostsWhen ZeroActiveSessions { get; } = new DesktopVirtualizationStopHostsWhen(ZeroActiveSessionsValue);
        /// <summary> Determines if two <see cref="DesktopVirtualizationStopHostsWhen"/> values are the same. </summary>
        public static bool operator ==(DesktopVirtualizationStopHostsWhen left, DesktopVirtualizationStopHostsWhen right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DesktopVirtualizationStopHostsWhen"/> values are not the same. </summary>
        public static bool operator !=(DesktopVirtualizationStopHostsWhen left, DesktopVirtualizationStopHostsWhen right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DesktopVirtualizationStopHostsWhen"/>. </summary>
        public static implicit operator DesktopVirtualizationStopHostsWhen(string value) => new DesktopVirtualizationStopHostsWhen(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DesktopVirtualizationStopHostsWhen other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DesktopVirtualizationStopHostsWhen other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
