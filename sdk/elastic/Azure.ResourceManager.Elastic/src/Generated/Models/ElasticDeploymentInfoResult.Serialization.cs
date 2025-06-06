// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticDeploymentInfoResult : IUtf8JsonSerializable, IJsonModel<ElasticDeploymentInfoResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticDeploymentInfoResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticDeploymentInfoResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticDeploymentInfoResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticDeploymentInfoResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(MemoryCapacity))
            {
                writer.WritePropertyName("memoryCapacity"u8);
                writer.WriteStringValue(MemoryCapacity);
            }
            if (options.Format != "W" && Optional.IsDefined(DiskCapacity))
            {
                writer.WritePropertyName("diskCapacity"u8);
                writer.WriteStringValue(DiskCapacity);
            }
            if (options.Format != "W" && Optional.IsDefined(ElasticsearchEndPoint))
            {
                writer.WritePropertyName("elasticsearchEndPoint"u8);
                writer.WriteStringValue(ElasticsearchEndPoint);
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentUri))
            {
                writer.WritePropertyName("deploymentUrl"u8);
                writer.WriteStringValue(DeploymentUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceSaasInfo))
            {
                writer.WritePropertyName("marketplaceSaasInfo"u8);
                writer.WriteObjectValue(MarketplaceSaasInfo, options);
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

        ElasticDeploymentInfoResult IJsonModel<ElasticDeploymentInfoResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticDeploymentInfoResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticDeploymentInfoResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticDeploymentInfoResult(document.RootElement, options);
        }

        internal static ElasticDeploymentInfoResult DeserializeElasticDeploymentInfoResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ElasticDeploymentStatus? status = default;
            string version = default;
            string memoryCapacity = default;
            string diskCapacity = default;
            string elasticsearchEndPoint = default;
            Uri deploymentUrl = default;
            MarketplaceSaaSInfo marketplaceSaasInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ElasticDeploymentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memoryCapacity"u8))
                {
                    memoryCapacity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskCapacity"u8))
                {
                    diskCapacity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticsearchEndPoint"u8))
                {
                    elasticsearchEndPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("marketplaceSaasInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSaasInfo = MarketplaceSaaSInfo.DeserializeMarketplaceSaaSInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ElasticDeploymentInfoResult(
                status,
                version,
                memoryCapacity,
                diskCapacity,
                elasticsearchEndPoint,
                deploymentUrl,
                marketplaceSaasInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticDeploymentInfoResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticDeploymentInfoResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerElasticContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ElasticDeploymentInfoResult)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticDeploymentInfoResult IPersistableModel<ElasticDeploymentInfoResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticDeploymentInfoResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeElasticDeploymentInfoResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticDeploymentInfoResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticDeploymentInfoResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
