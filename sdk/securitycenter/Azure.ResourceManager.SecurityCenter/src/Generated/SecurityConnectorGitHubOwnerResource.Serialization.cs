// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityConnectorGitHubOwnerResource : IJsonModel<SecurityConnectorGitHubOwnerData>
    {
        private static SecurityConnectorGitHubOwnerData s_dataDeserializationInstance;
        private static SecurityConnectorGitHubOwnerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SecurityConnectorGitHubOwnerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityConnectorGitHubOwnerData>)Data).Write(writer, options);

        SecurityConnectorGitHubOwnerData IJsonModel<SecurityConnectorGitHubOwnerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityConnectorGitHubOwnerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityConnectorGitHubOwnerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SecurityConnectorGitHubOwnerData>(Data, options, AzureResourceManagerSecurityCenterContext.Default);

        SecurityConnectorGitHubOwnerData IPersistableModel<SecurityConnectorGitHubOwnerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityConnectorGitHubOwnerData>(data, options, AzureResourceManagerSecurityCenterContext.Default);

        string IPersistableModel<SecurityConnectorGitHubOwnerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityConnectorGitHubOwnerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
