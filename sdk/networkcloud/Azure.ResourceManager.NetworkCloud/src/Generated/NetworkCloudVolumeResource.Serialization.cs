// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudVolumeResource : IJsonModel<NetworkCloudVolumeData>
    {
        private static NetworkCloudVolumeData s_dataDeserializationInstance;
        private static NetworkCloudVolumeData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<NetworkCloudVolumeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkCloudVolumeData>)Data).Write(writer, options);

        NetworkCloudVolumeData IJsonModel<NetworkCloudVolumeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkCloudVolumeData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkCloudVolumeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkCloudVolumeData>(Data, options, AzureResourceManagerNetworkCloudContext.Default);

        NetworkCloudVolumeData IPersistableModel<NetworkCloudVolumeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkCloudVolumeData>(data, options, AzureResourceManagerNetworkCloudContext.Default);

        string IPersistableModel<NetworkCloudVolumeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkCloudVolumeData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
