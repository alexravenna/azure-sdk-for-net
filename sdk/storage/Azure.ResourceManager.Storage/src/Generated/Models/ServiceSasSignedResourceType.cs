// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share (s). </summary>
    public readonly partial struct ServiceSasSignedResourceType : IEquatable<ServiceSasSignedResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceSasSignedResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceSasSignedResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BlobValue = "b";
        private const string ContainerValue = "c";
        private const string FileValue = "f";
        private const string ShareValue = "s";

        /// <summary> b. </summary>
        public static ServiceSasSignedResourceType Blob { get; } = new ServiceSasSignedResourceType(BlobValue);
        /// <summary> c. </summary>
        public static ServiceSasSignedResourceType Container { get; } = new ServiceSasSignedResourceType(ContainerValue);
        /// <summary> f. </summary>
        public static ServiceSasSignedResourceType File { get; } = new ServiceSasSignedResourceType(FileValue);
        /// <summary> s. </summary>
        public static ServiceSasSignedResourceType Share { get; } = new ServiceSasSignedResourceType(ShareValue);
        /// <summary> Determines if two <see cref="ServiceSasSignedResourceType"/> values are the same. </summary>
        public static bool operator ==(ServiceSasSignedResourceType left, ServiceSasSignedResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceSasSignedResourceType"/> values are not the same. </summary>
        public static bool operator !=(ServiceSasSignedResourceType left, ServiceSasSignedResourceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServiceSasSignedResourceType"/>. </summary>
        public static implicit operator ServiceSasSignedResourceType(string value) => new ServiceSasSignedResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceSasSignedResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceSasSignedResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
