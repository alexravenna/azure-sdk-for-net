// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataFlow : IUtf8JsonSerializable, IJsonModel<DataFlow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFlow>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFlow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlow)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Destinations))
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteStartArray();
                foreach (var item in Destinations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TransformKql))
            {
                writer.WritePropertyName("transformKql"u8);
                writer.WriteStringValue(TransformKql);
            }
            if (Optional.IsDefined(OutputStream))
            {
                writer.WritePropertyName("outputStream"u8);
                writer.WriteStringValue(OutputStream);
            }
            if (Optional.IsDefined(BuiltInTransform))
            {
                writer.WritePropertyName("builtInTransform"u8);
                writer.WriteStringValue(BuiltInTransform);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DataFlow IJsonModel<DataFlow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlow)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlow(document.RootElement, options);
        }

        internal static DataFlow DeserializeDataFlow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataFlowStream> streams = default;
            IList<string> destinations = default;
            string transformKql = default;
            string outputStream = default;
            string builtInTransform = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowStream> array = new List<DataFlowStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataFlowStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("destinations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinations = array;
                    continue;
                }
                if (property.NameEquals("transformKql"u8))
                {
                    transformKql = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputStream"u8))
                {
                    outputStream = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("builtInTransform"u8))
                {
                    builtInTransform = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFlow(
                streams ?? new ChangeTrackingList<DataFlowStream>(),
                destinations ?? new ChangeTrackingList<string>(),
                transformKql,
                outputStream,
                builtInTransform,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFlow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataFlow)} does not support writing '{options.Format}' format.");
            }
        }

        DataFlow IPersistableModel<DataFlow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataFlow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFlow)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFlow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
