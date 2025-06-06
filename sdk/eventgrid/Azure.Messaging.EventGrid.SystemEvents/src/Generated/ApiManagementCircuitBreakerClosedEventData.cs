// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ApiManagement.CircuitBreaker.Closed event. </summary>
    public partial class ApiManagementCircuitBreakerClosedEventData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementCircuitBreakerClosedEventData"/>. </summary>
        /// <param name="backendName"> Name of the backend for which the circuit has closed. </param>
        /// <param name="circuitBreaker"> Information related to the circuit breaker configured on the backend. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backendName"/> or <paramref name="circuitBreaker"/> is null. </exception>
        internal ApiManagementCircuitBreakerClosedEventData(string backendName, ApiManagementCircuitBreakerProperties circuitBreaker)
        {
            Argument.AssertNotNull(backendName, nameof(backendName));
            Argument.AssertNotNull(circuitBreaker, nameof(circuitBreaker));

            BackendName = backendName;
            CircuitBreaker = circuitBreaker;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementCircuitBreakerClosedEventData"/>. </summary>
        /// <param name="backendName"> Name of the backend for which the circuit has closed. </param>
        /// <param name="circuitBreaker"> Information related to the circuit breaker configured on the backend. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementCircuitBreakerClosedEventData(string backendName, ApiManagementCircuitBreakerProperties circuitBreaker, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BackendName = backendName;
            CircuitBreaker = circuitBreaker;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementCircuitBreakerClosedEventData"/> for deserialization. </summary>
        internal ApiManagementCircuitBreakerClosedEventData()
        {
        }

        /// <summary> Name of the backend for which the circuit has closed. </summary>
        public string BackendName { get; }
        /// <summary> Information related to the circuit breaker configured on the backend. </summary>
        public ApiManagementCircuitBreakerProperties CircuitBreaker { get; }
    }
}
