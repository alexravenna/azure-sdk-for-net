// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The state of the Windows OS (i.e. NonSysprepped, SysprepRequested, SysprepApplied). </summary>
    public readonly partial struct WindowsOSState : IEquatable<WindowsOSState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WindowsOSState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WindowsOSState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NonSyspreppedValue = "NonSysprepped";
        private const string SysprepRequestedValue = "SysprepRequested";
        private const string SysprepAppliedValue = "SysprepApplied";

        /// <summary> NonSysprepped. </summary>
        public static WindowsOSState NonSysprepped { get; } = new WindowsOSState(NonSyspreppedValue);
        /// <summary> SysprepRequested. </summary>
        public static WindowsOSState SysprepRequested { get; } = new WindowsOSState(SysprepRequestedValue);
        /// <summary> SysprepApplied. </summary>
        public static WindowsOSState SysprepApplied { get; } = new WindowsOSState(SysprepAppliedValue);
        /// <summary> Determines if two <see cref="WindowsOSState"/> values are the same. </summary>
        public static bool operator ==(WindowsOSState left, WindowsOSState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WindowsOSState"/> values are not the same. </summary>
        public static bool operator !=(WindowsOSState left, WindowsOSState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WindowsOSState"/>. </summary>
        public static implicit operator WindowsOSState(string value) => new WindowsOSState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WindowsOSState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WindowsOSState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
