// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CloudHealth.Models
{
    public partial class HealthModelEntityProperties : IUtf8JsonSerializable, IJsonModel<HealthModelEntityProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthModelEntityProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthModelEntityProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthModelEntityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthModelEntityProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(CanvasPosition))
            {
                writer.WritePropertyName("canvasPosition"u8);
                writer.WriteObjectValue(CanvasPosition, options);
            }
            if (Optional.IsDefined(Icon))
            {
                writer.WritePropertyName("icon"u8);
                writer.WriteObjectValue(Icon, options);
            }
            if (Optional.IsDefined(HealthObjective))
            {
                writer.WritePropertyName("healthObjective"u8);
                writer.WriteNumberValue(HealthObjective.Value);
            }
            if (Optional.IsDefined(Impact))
            {
                writer.WritePropertyName("impact"u8);
                writer.WriteStringValue(Impact.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in Labels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Signals))
            {
                writer.WritePropertyName("signals"u8);
                writer.WriteObjectValue(Signals, options);
            }
            if (options.Format != "W" && Optional.IsDefined(DiscoveredBy))
            {
                writer.WritePropertyName("discoveredBy"u8);
                writer.WriteStringValue(DiscoveredBy);
            }
            if (options.Format != "W" && Optional.IsDefined(DeletedOn))
            {
                writer.WritePropertyName("deletionDate"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(HealthState))
            {
                writer.WritePropertyName("healthState"u8);
                writer.WriteStringValue(HealthState.Value.ToString());
            }
            if (Optional.IsDefined(Alerts))
            {
                writer.WritePropertyName("alerts"u8);
                writer.WriteObjectValue(Alerts, options);
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

        HealthModelEntityProperties IJsonModel<HealthModelEntityProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthModelEntityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthModelEntityProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthModelEntityProperties(document.RootElement, options);
        }

        internal static HealthModelEntityProperties DeserializeHealthModelEntityProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthModelProvisioningState? provisioningState = default;
            string displayName = default;
            string kind = default;
            EntityCoordinates canvasPosition = default;
            EntityIcon icon = default;
            float? healthObjective = default;
            EntityImpact? impact = default;
            IDictionary<string, string> labels = default;
            EntitySignalGroup signals = default;
            string discoveredBy = default;
            DateTimeOffset? deletionDate = default;
            EntityHealthState? healthState = default;
            EntityAlerts alerts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HealthModelProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("canvasPosition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canvasPosition = EntityCoordinates.DeserializeEntityCoordinates(property.Value, options);
                    continue;
                }
                if (property.NameEquals("icon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    icon = EntityIcon.DeserializeEntityIcon(property.Value, options);
                    continue;
                }
                if (property.NameEquals("healthObjective"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthObjective = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("impact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    impact = new EntityImpact(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("signals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signals = EntitySignalGroup.DeserializeEntitySignalGroup(property.Value, options);
                    continue;
                }
                if (property.NameEquals("discoveredBy"u8))
                {
                    discoveredBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("healthState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthState = new EntityHealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alerts = EntityAlerts.DeserializeEntityAlerts(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthModelEntityProperties(
                provisioningState,
                displayName,
                kind,
                canvasPosition,
                icon,
                healthObjective,
                impact,
                labels ?? new ChangeTrackingDictionary<string, string>(),
                signals,
                discoveredBy,
                deletionDate,
                healthState,
                alerts,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthModelEntityProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthModelEntityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCloudHealthContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HealthModelEntityProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HealthModelEntityProperties IPersistableModel<HealthModelEntityProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthModelEntityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHealthModelEntityProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthModelEntityProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthModelEntityProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
