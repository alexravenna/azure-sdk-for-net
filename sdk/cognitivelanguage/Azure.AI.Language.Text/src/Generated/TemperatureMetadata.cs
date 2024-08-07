// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Represents the Information entity Metadata model. </summary>
    public partial class TemperatureMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="TemperatureMetadata"/>. </summary>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> Unit of measure for temperature. </param>
        internal TemperatureMetadata(double value, TemperatureUnit unit)
        {
            MetadataKind = MetadataKind.TemperatureMetadata;
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="TemperatureMetadata"/>. </summary>
        /// <param name="metadataKind"> The entity Metadata object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> Unit of measure for temperature. </param>
        internal TemperatureMetadata(MetadataKind metadataKind, IDictionary<string, BinaryData> serializedAdditionalRawData, double value, TemperatureUnit unit) : base(metadataKind, serializedAdditionalRawData)
        {
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="TemperatureMetadata"/> for deserialization. </summary>
        internal TemperatureMetadata()
        {
        }

        /// <summary> The numeric value that the extracted text denotes. </summary>
        public double Value { get; }
        /// <summary> Unit of measure for temperature. </summary>
        public TemperatureUnit Unit { get; }
    }
}
