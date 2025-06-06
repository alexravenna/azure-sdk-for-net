// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceTagProductLinkResource : IJsonModel<TagProductLinkContractData>
    {
        private static TagProductLinkContractData s_dataDeserializationInstance;
        private static TagProductLinkContractData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<TagProductLinkContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TagProductLinkContractData>)Data).Write(writer, options);

        TagProductLinkContractData IJsonModel<TagProductLinkContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TagProductLinkContractData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<TagProductLinkContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<TagProductLinkContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        TagProductLinkContractData IPersistableModel<TagProductLinkContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TagProductLinkContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<TagProductLinkContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TagProductLinkContractData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
