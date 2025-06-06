// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryDraDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryDraDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryDraDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryDraDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDraDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDraDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartbeatUtc"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Health))
            {
                writer.WritePropertyName("health"u8);
                writer.WriteStringValue(Health.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ForwardProtectedItemCount))
            {
                writer.WritePropertyName("forwardProtectedItemCount"u8);
                writer.WriteNumberValue(ForwardProtectedItemCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReverseProtectedItemCount))
            {
                writer.WritePropertyName("reverseProtectedItemCount"u8);
                writer.WriteNumberValue(ReverseProtectedItemCount.Value);
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

        SiteRecoveryDraDetails IJsonModel<SiteRecoveryDraDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDraDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDraDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryDraDetails(document.RootElement, options);
        }

        internal static SiteRecoveryDraDetails DeserializeSiteRecoveryDraDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string biosId = default;
            string version = default;
            DateTimeOffset? lastHeartbeatUtc = default;
            SiteRecoveryProtectionHealth? health = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            int? forwardProtectedItemCount = default;
            int? reverseProtectedItemCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("health"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    health = new SiteRecoveryProtectionHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("forwardProtectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardProtectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reverseProtectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseProtectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryDraDetails(
                id,
                name,
                biosId,
                version,
                lastHeartbeatUtc,
                health,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                forwardProtectedItemCount,
                reverseProtectedItemCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryDraDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDraDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDraDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryDraDetails IPersistableModel<SiteRecoveryDraDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDraDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSiteRecoveryDraDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDraDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryDraDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
