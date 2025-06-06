// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class SshPublicKeyGenerateKeyPairResult : IUtf8JsonSerializable, IJsonModel<SshPublicKeyGenerateKeyPairResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SshPublicKeyGenerateKeyPairResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SshPublicKeyGenerateKeyPairResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshPublicKeyGenerateKeyPairResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SshPublicKeyGenerateKeyPairResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("privateKey"u8);
            writer.WriteStringValue(PrivateKey);
            writer.WritePropertyName("publicKey"u8);
            writer.WriteStringValue(PublicKey);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
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

        SshPublicKeyGenerateKeyPairResult IJsonModel<SshPublicKeyGenerateKeyPairResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshPublicKeyGenerateKeyPairResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SshPublicKeyGenerateKeyPairResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSshPublicKeyGenerateKeyPairResult(document.RootElement, options);
        }

        internal static SshPublicKeyGenerateKeyPairResult DeserializeSshPublicKeyGenerateKeyPairResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string privateKey = default;
            string publicKey = default;
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SshPublicKeyGenerateKeyPairResult(privateKey, publicKey, id, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SshPublicKeyGenerateKeyPairResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshPublicKeyGenerateKeyPairResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SshPublicKeyGenerateKeyPairResult)} does not support writing '{options.Format}' format.");
            }
        }

        SshPublicKeyGenerateKeyPairResult IPersistableModel<SshPublicKeyGenerateKeyPairResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SshPublicKeyGenerateKeyPairResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSshPublicKeyGenerateKeyPairResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SshPublicKeyGenerateKeyPairResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SshPublicKeyGenerateKeyPairResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
