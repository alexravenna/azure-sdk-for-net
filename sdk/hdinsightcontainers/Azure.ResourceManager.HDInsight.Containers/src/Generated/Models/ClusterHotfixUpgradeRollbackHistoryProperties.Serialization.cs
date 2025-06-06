// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterHotfixUpgradeRollbackHistoryProperties : IUtf8JsonSerializable, IJsonModel<ClusterHotfixUpgradeRollbackHistoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterHotfixUpgradeRollbackHistoryProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterHotfixUpgradeRollbackHistoryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterHotfixUpgradeRollbackHistoryProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ClusterHotfixUpgradeRollbackHistoryProperties IJsonModel<ClusterHotfixUpgradeRollbackHistoryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterHotfixUpgradeRollbackHistoryProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterHotfixUpgradeRollbackHistoryProperties(document.RootElement, options);
        }

        internal static ClusterHotfixUpgradeRollbackHistoryProperties DeserializeClusterHotfixUpgradeRollbackHistoryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceClusterVersion = default;
            string sourceOssVersion = default;
            string sourceBuildNumber = default;
            string targetClusterVersion = default;
            string targetOssVersion = default;
            string targetBuildNumber = default;
            string componentName = default;
            ClusterUpgradeHistorySeverityType? severity = default;
            ClusterUpgradeHistoryType upgradeType = default;
            string utcTime = default;
            ClusterUpgradeHistoryUpgradeResultType upgradeResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceClusterVersion"u8))
                {
                    sourceClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceOssVersion"u8))
                {
                    sourceOssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceBuildNumber"u8))
                {
                    sourceBuildNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetClusterVersion"u8))
                {
                    targetClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetOssVersion"u8))
                {
                    targetOssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBuildNumber"u8))
                {
                    targetBuildNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentName"u8))
                {
                    componentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new ClusterUpgradeHistorySeverityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterUpgradeHistoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("utcTime"u8))
                {
                    utcTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeResult"u8))
                {
                    upgradeResult = new ClusterUpgradeHistoryUpgradeResultType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterHotfixUpgradeRollbackHistoryProperties(
                upgradeType,
                utcTime,
                upgradeResult,
                serializedAdditionalRawData,
                sourceClusterVersion,
                sourceOssVersion,
                sourceBuildNumber,
                targetClusterVersion,
                targetOssVersion,
                targetBuildNumber,
                componentName,
                severity);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceClusterVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceClusterVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceClusterVersion))
                {
                    builder.Append("  sourceClusterVersion: ");
                    if (SourceClusterVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceClusterVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceClusterVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceOssVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceOssVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceOssVersion))
                {
                    builder.Append("  sourceOssVersion: ");
                    if (SourceOssVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceOssVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceOssVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceBuildNumber), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceBuildNumber: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceBuildNumber))
                {
                    builder.Append("  sourceBuildNumber: ");
                    if (SourceBuildNumber.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceBuildNumber}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceBuildNumber}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetClusterVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetClusterVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetClusterVersion))
                {
                    builder.Append("  targetClusterVersion: ");
                    if (TargetClusterVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TargetClusterVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TargetClusterVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetOssVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetOssVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetOssVersion))
                {
                    builder.Append("  targetOssVersion: ");
                    if (TargetOssVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TargetOssVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TargetOssVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetBuildNumber), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  targetBuildNumber: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TargetBuildNumber))
                {
                    builder.Append("  targetBuildNumber: ");
                    if (TargetBuildNumber.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TargetBuildNumber}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TargetBuildNumber}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComponentName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  componentName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComponentName))
                {
                    builder.Append("  componentName: ");
                    if (ComponentName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ComponentName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ComponentName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Severity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  severity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Severity))
                {
                    builder.Append("  severity: ");
                    builder.AppendLine($"'{Severity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine($"'{UpgradeType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UtcTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  utcTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UtcTime))
                {
                    builder.Append("  utcTime: ");
                    if (UtcTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UtcTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UtcTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeResult), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeResult: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeResult: ");
                builder.AppendLine($"'{UpgradeResult.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHDInsightContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterHotfixUpgradeRollbackHistoryProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterHotfixUpgradeRollbackHistoryProperties IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterHotfixUpgradeRollbackHistoryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterHotfixUpgradeRollbackHistoryProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterHotfixUpgradeRollbackHistoryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
