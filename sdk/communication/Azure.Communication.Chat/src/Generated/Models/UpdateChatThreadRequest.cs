// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for updating a chat thread. </summary>
    internal partial class UpdateChatThreadRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateChatThreadRequest"/>. </summary>
        public UpdateChatThreadRequest()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateChatThreadRequest"/>. </summary>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="metadata"> Contextual metadata for the thread. The metadata consists of name/value pairs. The total size of all metadata pairs can be up to 1KB in size. </param>
        /// <param name="retentionPolicy">
        /// Data retention policy for auto deletion.
        /// Please note <see cref="ChatRetentionPolicyInternal"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NoneRetentionPolicyInternal"/> and <see cref="ThreadCreationDateRetentionPolicyInternal"/>.
        /// </param>
        internal UpdateChatThreadRequest(string topic, IDictionary<string, string> metadata, ChatRetentionPolicyInternal retentionPolicy)
        {
            Topic = topic;
            Metadata = metadata;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> Chat thread topic. </summary>
        public string Topic { get; set; }
        /// <summary> Contextual metadata for the thread. The metadata consists of name/value pairs. The total size of all metadata pairs can be up to 1KB in size. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary>
        /// Data retention policy for auto deletion.
        /// Please note <see cref="ChatRetentionPolicyInternal"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NoneRetentionPolicyInternal"/> and <see cref="ThreadCreationDateRetentionPolicyInternal"/>.
        /// </summary>
        public ChatRetentionPolicyInternal RetentionPolicy { get; set; }
    }
}
