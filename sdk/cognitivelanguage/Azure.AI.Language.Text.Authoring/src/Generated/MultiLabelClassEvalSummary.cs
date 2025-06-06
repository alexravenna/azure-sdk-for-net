// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the evaluation summary of a class in a multi-label classification project. </summary>
    public partial class MultiLabelClassEvalSummary
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

        /// <summary> Initializes a new instance of <see cref="MultiLabelClassEvalSummary"/>. </summary>
        /// <param name="f1"> Represents the model precision. </param>
        /// <param name="precision"> Represents the model recall. </param>
        /// <param name="recall"> Represents the model F1 score. </param>
        /// <param name="truePositiveCount"> Represents the count of true positive. </param>
        /// <param name="trueNegativeCount"> Represents the count of true negative. </param>
        /// <param name="falsePositiveCount"> Represents the count of false positive. </param>
        /// <param name="falseNegativeCount"> Represents the count of false negative. </param>
        internal MultiLabelClassEvalSummary(double f1, double precision, double recall, int truePositiveCount, int trueNegativeCount, int falsePositiveCount, int falseNegativeCount)
        {
            F1 = f1;
            Precision = precision;
            Recall = recall;
            TruePositiveCount = truePositiveCount;
            TrueNegativeCount = trueNegativeCount;
            FalsePositiveCount = falsePositiveCount;
            FalseNegativeCount = falseNegativeCount;
        }

        /// <summary> Initializes a new instance of <see cref="MultiLabelClassEvalSummary"/>. </summary>
        /// <param name="f1"> Represents the model precision. </param>
        /// <param name="precision"> Represents the model recall. </param>
        /// <param name="recall"> Represents the model F1 score. </param>
        /// <param name="truePositiveCount"> Represents the count of true positive. </param>
        /// <param name="trueNegativeCount"> Represents the count of true negative. </param>
        /// <param name="falsePositiveCount"> Represents the count of false positive. </param>
        /// <param name="falseNegativeCount"> Represents the count of false negative. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultiLabelClassEvalSummary(double f1, double precision, double recall, int truePositiveCount, int trueNegativeCount, int falsePositiveCount, int falseNegativeCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            F1 = f1;
            Precision = precision;
            Recall = recall;
            TruePositiveCount = truePositiveCount;
            TrueNegativeCount = trueNegativeCount;
            FalsePositiveCount = falsePositiveCount;
            FalseNegativeCount = falseNegativeCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MultiLabelClassEvalSummary"/> for deserialization. </summary>
        internal MultiLabelClassEvalSummary()
        {
        }

        /// <summary> Represents the model precision. </summary>
        public double F1 { get; }
        /// <summary> Represents the model recall. </summary>
        public double Precision { get; }
        /// <summary> Represents the model F1 score. </summary>
        public double Recall { get; }
        /// <summary> Represents the count of true positive. </summary>
        public int TruePositiveCount { get; }
        /// <summary> Represents the count of true negative. </summary>
        public int TrueNegativeCount { get; }
        /// <summary> Represents the count of false positive. </summary>
        public int FalsePositiveCount { get; }
        /// <summary> Represents the count of false negative. </summary>
        public int FalseNegativeCount { get; }
    }
}
