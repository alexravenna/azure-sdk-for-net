// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class ServerThreatProtectionSettingsModelResource : IJsonModel<ServerThreatProtectionSettingsModelData>
    {
        void IJsonModel<ServerThreatProtectionSettingsModelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServerThreatProtectionSettingsModelData>)Data).Write(writer, options);

        ServerThreatProtectionSettingsModelData IJsonModel<ServerThreatProtectionSettingsModelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServerThreatProtectionSettingsModelData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServerThreatProtectionSettingsModelData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ServerThreatProtectionSettingsModelData IPersistableModel<ServerThreatProtectionSettingsModelData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServerThreatProtectionSettingsModelData>(data, options);

        string IPersistableModel<ServerThreatProtectionSettingsModelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServerThreatProtectionSettingsModelData>)Data).GetFormatFromOptions(options);
    }
}
