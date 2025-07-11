// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> List of conversation items. </summary>
    public partial class ConversationalAIItem
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

        /// <summary> Initializes a new instance of <see cref="ConversationalAIItem"/>. </summary>
        /// <param name="id"> The ID of a conversation item. </param>
        /// <param name="participantId"> The participant ID of a conversation item. </param>
        /// <param name="text"> The text input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="participantId"/> or <paramref name="text"/> is null. </exception>
        public ConversationalAIItem(string id, string participantId, string text)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(participantId, nameof(participantId));
            Argument.AssertNotNull(text, nameof(text));

            Id = id;
            ParticipantId = participantId;
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAIItem"/>. </summary>
        /// <param name="id"> The ID of a conversation item. </param>
        /// <param name="participantId"> The participant ID of a conversation item. </param>
        /// <param name="text"> The text input. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationalAIItem(string id, string participantId, string text, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ParticipantId = participantId;
            Text = text;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAIItem"/> for deserialization. </summary>
        internal ConversationalAIItem()
        {
        }

        /// <summary> The ID of a conversation item. </summary>
        public string Id { get; }
        /// <summary> The participant ID of a conversation item. </summary>
        public string ParticipantId { get; }
        /// <summary> The text input. </summary>
        public string Text { get; }
    }
}
