// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverOperationsDiscovery : IUtf8JsonSerializable, IJsonModel<MoverOperationsDiscovery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverOperationsDiscovery>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MoverOperationsDiscovery>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationsDiscovery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverOperationsDiscovery)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsDataAction))
            {
                writer.WritePropertyName("isDataAction"u8);
                writer.WriteBooleanValue(IsDataAction.Value);
            }
            if (Optional.IsDefined(Display))
            {
                writer.WritePropertyName("display"u8);
                writer.WriteObjectValue(Display, options);
            }
            if (Optional.IsDefined(Origin))
            {
                writer.WritePropertyName("origin"u8);
                writer.WriteStringValue(Origin);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Properties);
#else
                using (JsonDocument document = JsonDocument.Parse(Properties, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        MoverOperationsDiscovery IJsonModel<MoverOperationsDiscovery>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationsDiscovery>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverOperationsDiscovery)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverOperationsDiscovery(document.RootElement, options);
        }

        internal static MoverOperationsDiscovery DeserializeMoverOperationsDiscovery(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            bool? isDataAction = default;
            MoverDisplayInfo display = default;
            string origin = default;
            BinaryData properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDataAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDataAction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("display"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    display = MoverDisplayInfo.DeserializeMoverDisplayInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("origin"u8))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MoverOperationsDiscovery(
                name,
                isDataAction,
                display,
                origin,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverOperationsDiscovery>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationsDiscovery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourceMoverContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MoverOperationsDiscovery)} does not support writing '{options.Format}' format.");
            }
        }

        MoverOperationsDiscovery IPersistableModel<MoverOperationsDiscovery>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationsDiscovery>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMoverOperationsDiscovery(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverOperationsDiscovery)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverOperationsDiscovery>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
