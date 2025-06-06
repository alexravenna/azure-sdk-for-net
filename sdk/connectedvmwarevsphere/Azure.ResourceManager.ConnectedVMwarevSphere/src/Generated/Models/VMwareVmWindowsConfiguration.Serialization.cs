// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class VMwareVmWindowsConfiguration : IUtf8JsonSerializable, IJsonModel<VMwareVmWindowsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareVmWindowsConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareVmWindowsConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmWindowsConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FullName))
            {
                writer.WritePropertyName("fullName"u8);
                writer.WriteStringValue(FullName);
            }
            if (Optional.IsDefined(OrgName))
            {
                writer.WritePropertyName("orgName"u8);
                writer.WriteStringValue(OrgName);
            }
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsDefined(DomainUsername))
            {
                writer.WritePropertyName("domainUsername"u8);
                writer.WriteStringValue(DomainUsername);
            }
            if (Optional.IsDefined(DomainUserPassword))
            {
                writer.WritePropertyName("domainUserPassword"u8);
                writer.WriteStringValue(DomainUserPassword);
            }
            if (Optional.IsDefined(WorkGroupName))
            {
                writer.WritePropertyName("workGroupName"u8);
                writer.WriteStringValue(WorkGroupName);
            }
            if (Optional.IsDefined(ProductId))
            {
                writer.WritePropertyName("productId"u8);
                writer.WriteStringValue(ProductId);
            }
            if (Optional.IsDefined(IsAutoLogon))
            {
                writer.WritePropertyName("autoLogon"u8);
                writer.WriteBooleanValue(IsAutoLogon.Value);
            }
            if (Optional.IsDefined(AutoLogonCount))
            {
                writer.WritePropertyName("autoLogonCount"u8);
                writer.WriteNumberValue(AutoLogonCount.Value);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsCollectionDefined(FirstLogonCommands))
            {
                writer.WritePropertyName("firstLogonCommands"u8);
                writer.WriteStartArray();
                foreach (var item in FirstLogonCommands)
                {
                    writer.WriteStringValue(item);
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

        VMwareVmWindowsConfiguration IJsonModel<VMwareVmWindowsConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmWindowsConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareVmWindowsConfiguration(document.RootElement, options);
        }

        internal static VMwareVmWindowsConfiguration DeserializeVMwareVmWindowsConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fullName = default;
            string orgName = default;
            string domainName = default;
            string domainUsername = default;
            string domainUserPassword = default;
            string workGroupName = default;
            string productId = default;
            bool? autoLogon = default;
            int? autoLogonCount = default;
            string timeZone = default;
            IList<string> firstLogonCommands = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fullName"u8))
                {
                    fullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orgName"u8))
                {
                    orgName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainUsername"u8))
                {
                    domainUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainUserPassword"u8))
                {
                    domainUserPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workGroupName"u8))
                {
                    workGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoLogon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoLogon = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoLogonCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoLogonCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstLogonCommands"u8))
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
                    firstLogonCommands = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareVmWindowsConfiguration(
                fullName,
                orgName,
                domainName,
                domainUsername,
                domainUserPassword,
                workGroupName,
                productId,
                autoLogon,
                autoLogonCount,
                timeZone,
                firstLogonCommands ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareVmWindowsConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConnectedVMwarevSphereContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VMwareVmWindowsConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareVmWindowsConfiguration IPersistableModel<VMwareVmWindowsConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmWindowsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVMwareVmWindowsConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareVmWindowsConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareVmWindowsConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
