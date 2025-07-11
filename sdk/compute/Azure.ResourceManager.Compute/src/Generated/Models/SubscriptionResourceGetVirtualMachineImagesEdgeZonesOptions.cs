// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The SubscriptionResourceGetVirtualMachineImagesEdgeZonesOptions. </summary>
    public partial class SubscriptionResourceGetVirtualMachineImagesEdgeZonesOptions
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionResourceGetVirtualMachineImagesEdgeZonesOptions"/>. </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/> or <paramref name="skus"/> is null. </exception>
        public SubscriptionResourceGetVirtualMachineImagesEdgeZonesOptions(AzureLocation location, string edgeZone, string publisherName, string offer, string skus)
        {
            Argument.AssertNotNull(edgeZone, nameof(edgeZone));
            Argument.AssertNotNull(publisherName, nameof(publisherName));
            Argument.AssertNotNull(offer, nameof(offer));
            Argument.AssertNotNull(skus, nameof(skus));

            Location = location;
            EdgeZone = edgeZone;
            PublisherName = publisherName;
            Offer = offer;
            Skus = skus;
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionResourceGetVirtualMachineImagesEdgeZonesOptions"/> for deserialization. </summary>
        internal SubscriptionResourceGetVirtualMachineImagesEdgeZonesOptions()
        {
        }

        /// <summary> The name of Azure region. </summary>
        public AzureLocation Location { get; }
        /// <summary> The name of the edge zone. </summary>
        public string EdgeZone { get; }
        /// <summary> A valid image publisher. </summary>
        public string PublisherName { get; }
        /// <summary> A valid image publisher offer. </summary>
        public string Offer { get; }
        /// <summary> A valid image SKU. </summary>
        public string Skus { get; }
        /// <summary> The expand expression to apply on the operation. </summary>
        public string Expand { get; set; }
        /// <summary> An integer value specifying the number of images to return that matches supplied values. </summary>
        public int? Top { get; set; }
        /// <summary> Specifies the order of the results returned. Formatted as an OData query. </summary>
        public string Orderby { get; set; }
    }
}
