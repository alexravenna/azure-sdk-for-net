// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text
{
    /// <summary> Every relation is an entity graph of a certain relationType, where all entities are connected and have specific roles within the relation context. </summary>
    public partial class HealthcareRelation
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

        /// <summary> Initializes a new instance of <see cref="HealthcareRelation"/>. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </param>
        /// <param name="entities"> The entities in the relation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entities"/> is null. </exception>
        internal HealthcareRelation(RelationType relationType, IEnumerable<HealthcareRelationEntity> entities)
        {
            Argument.AssertNotNull(entities, nameof(entities));

            RelationType = relationType;
            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareRelation"/>. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </param>
        /// <param name="entities"> The entities in the relation. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted relation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareRelation(RelationType relationType, IReadOnlyList<HealthcareRelationEntity> entities, double? confidenceScore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RelationType = relationType;
            Entities = entities;
            ConfidenceScore = confidenceScore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareRelation"/> for deserialization. </summary>
        internal HealthcareRelation()
        {
        }

        /// <summary> Type of relation. Examples include: `DosageOfMedication` or 'FrequencyOfMedication', etc. </summary>
        public RelationType RelationType { get; }
        /// <summary> The entities in the relation. </summary>
        public IReadOnlyList<HealthcareRelationEntity> Entities { get; }
        /// <summary> Confidence score between 0 and 1 of the extracted relation. </summary>
        public double? ConfidenceScore { get; }
    }
}
