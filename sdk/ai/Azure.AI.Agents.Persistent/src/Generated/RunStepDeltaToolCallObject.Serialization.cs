// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Agents.Persistent
{
    public partial class RunStepDeltaToolCallObject : IUtf8JsonSerializable, IJsonModel<RunStepDeltaToolCallObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunStepDeltaToolCallObject>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RunStepDeltaToolCallObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaToolCallObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepDeltaToolCallObject)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(ToolCalls))
            {
                writer.WritePropertyName("tool_calls"u8);
                writer.WriteStartArray();
                foreach (var item in ToolCalls)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        RunStepDeltaToolCallObject IJsonModel<RunStepDeltaToolCallObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaToolCallObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepDeltaToolCallObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepDeltaToolCallObject(document.RootElement, options);
        }

        internal static RunStepDeltaToolCallObject DeserializeRunStepDeltaToolCallObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RunStepDeltaToolCall> toolCalls = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool_calls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RunStepDeltaToolCall> array = new List<RunStepDeltaToolCall>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunStepDeltaToolCall.DeserializeRunStepDeltaToolCall(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RunStepDeltaToolCallObject(type, serializedAdditionalRawData, toolCalls ?? new ChangeTrackingList<RunStepDeltaToolCall>());
        }

        BinaryData IPersistableModel<RunStepDeltaToolCallObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaToolCallObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIAgentsPersistentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RunStepDeltaToolCallObject)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepDeltaToolCallObject IPersistableModel<RunStepDeltaToolCallObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepDeltaToolCallObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRunStepDeltaToolCallObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepDeltaToolCallObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepDeltaToolCallObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RunStepDeltaToolCallObject FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRunStepDeltaToolCallObject(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
