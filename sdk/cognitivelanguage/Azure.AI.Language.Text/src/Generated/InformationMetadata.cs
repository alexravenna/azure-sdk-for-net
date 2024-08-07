// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Represents the Information (data) entity Metadata model. </summary>
    public partial class InformationMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="InformationMetadata"/>. </summary>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> Unit of measure for information. </param>
        internal InformationMetadata(double value, InformationUnit unit)
        {
            MetadataKind = MetadataKind.InformationMetadata;
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="InformationMetadata"/>. </summary>
        /// <param name="metadataKind"> The entity Metadata object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> Unit of measure for information. </param>
        internal InformationMetadata(MetadataKind metadataKind, IDictionary<string, BinaryData> serializedAdditionalRawData, double value, InformationUnit unit) : base(metadataKind, serializedAdditionalRawData)
        {
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="InformationMetadata"/> for deserialization. </summary>
        internal InformationMetadata()
        {
        }

        /// <summary> The numeric value that the extracted text denotes. </summary>
        public double Value { get; }
        /// <summary> Unit of measure for information. </summary>
        public InformationUnit Unit { get; }
    }
}
