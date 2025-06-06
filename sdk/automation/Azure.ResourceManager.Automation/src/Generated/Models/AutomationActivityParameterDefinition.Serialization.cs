// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationActivityParameterDefinition : IUtf8JsonSerializable, IJsonModel<AutomationActivityParameterDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationActivityParameterDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutomationActivityParameterDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ActivityParameterType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ActivityParameterType);
            }
            if (Optional.IsDefined(IsMandatory))
            {
                writer.WritePropertyName("isMandatory"u8);
                writer.WriteBooleanValue(IsMandatory.Value);
            }
            if (Optional.IsDefined(IsDynamic))
            {
                writer.WritePropertyName("isDynamic"u8);
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            if (Optional.IsDefined(Position))
            {
                writer.WritePropertyName("position"u8);
                writer.WriteNumberValue(Position.Value);
            }
            if (Optional.IsDefined(CanTakeValueFromPipeline))
            {
                writer.WritePropertyName("valueFromPipeline"u8);
                writer.WriteBooleanValue(CanTakeValueFromPipeline.Value);
            }
            if (Optional.IsDefined(CanTakeValueFromPipelineByPropertyName))
            {
                writer.WritePropertyName("valueFromPipelineByPropertyName"u8);
                writer.WriteBooleanValue(CanTakeValueFromPipelineByPropertyName.Value);
            }
            if (Optional.IsDefined(CanTakeValueValueFromRemainingArguments))
            {
                writer.WritePropertyName("valueFromRemainingArguments"u8);
                writer.WriteBooleanValue(CanTakeValueValueFromRemainingArguments.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(ValidationSet))
            {
                writer.WritePropertyName("validationSet"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationSet)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        AutomationActivityParameterDefinition IJsonModel<AutomationActivityParameterDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationActivityParameterDefinition(document.RootElement, options);
        }

        internal static AutomationActivityParameterDefinition DeserializeAutomationActivityParameterDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            bool? isMandatory = default;
            bool? isDynamic = default;
            long? position = default;
            bool? valueFromPipeline = default;
            bool? valueFromPipelineByPropertyName = default;
            bool? valueFromRemainingArguments = default;
            string description = default;
            IReadOnlyList<AutomationActivityParameterValidationSet> validationSet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMandatory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDynamic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDynamic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("valueFromPipeline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFromPipeline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueFromPipelineByPropertyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFromPipelineByPropertyName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueFromRemainingArguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFromRemainingArguments = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationActivityParameterValidationSet> array = new List<AutomationActivityParameterValidationSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationActivityParameterValidationSet.DeserializeAutomationActivityParameterValidationSet(item, options));
                    }
                    validationSet = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutomationActivityParameterDefinition(
                name,
                type,
                isMandatory,
                isDynamic,
                position,
                valueFromPipeline,
                valueFromPipelineByPropertyName,
                valueFromRemainingArguments,
                description,
                validationSet ?? new ChangeTrackingList<AutomationActivityParameterValidationSet>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationActivityParameterDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAutomationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        AutomationActivityParameterDefinition IPersistableModel<AutomationActivityParameterDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivityParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutomationActivityParameterDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationActivityParameterDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationActivityParameterDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
