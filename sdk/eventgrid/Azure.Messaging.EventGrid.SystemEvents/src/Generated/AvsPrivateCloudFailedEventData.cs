// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AVS.PrivateCloudFailed event. </summary>
    public partial class AvsPrivateCloudFailedEventData : AvsPrivateCloudEventData
    {
        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudFailedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        internal AvsPrivateCloudFailedEventData(string operationId) : base(operationId)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudFailedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="failureMessage"> Failure reason of an event. </param>
        internal AvsPrivateCloudFailedEventData(string operationId, IDictionary<string, BinaryData> serializedAdditionalRawData, string failureMessage) : base(operationId, serializedAdditionalRawData)
        {
            FailureMessage = failureMessage;
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudFailedEventData"/> for deserialization. </summary>
        internal AvsPrivateCloudFailedEventData()
        {
        }

        /// <summary> Failure reason of an event. </summary>
        public string FailureMessage { get; }
    }
}
