// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class RequiredAmlFileSystemSubnetsSizeContent : IUtf8JsonSerializable, IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(StorageCapacityTiB))
            {
                writer.WritePropertyName("storageCapacityTiB"u8);
                writer.WriteNumberValue(StorageCapacityTiB.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
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

        RequiredAmlFileSystemSubnetsSizeContent IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequiredAmlFileSystemSubnetsSizeContent(document.RootElement, options);
        }

        internal static RequiredAmlFileSystemSubnetsSizeContent DeserializeRequiredAmlFileSystemSubnetsSizeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? storageCapacityTiB = default;
            StorageCacheSkuName sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageCapacityTiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageCapacityTiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageCacheSkuName.DeserializeStorageCacheSkuName(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RequiredAmlFileSystemSubnetsSizeContent(storageCapacityTiB, sku, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageCacheContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support writing '{options.Format}' format.");
            }
        }

        RequiredAmlFileSystemSubnetsSizeContent IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRequiredAmlFileSystemSubnetsSizeContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
