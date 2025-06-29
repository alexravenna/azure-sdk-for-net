// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ConnectedCache
{
    public partial class IspCustomerResource : IJsonModel<IspCustomerData>
    {
        private static IspCustomerData s_dataDeserializationInstance;
        private static IspCustomerData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<IspCustomerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<IspCustomerData>)Data).Write(writer, options);

        IspCustomerData IJsonModel<IspCustomerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<IspCustomerData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<IspCustomerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<IspCustomerData>(Data, options, AzureResourceManagerConnectedCacheContext.Default);

        IspCustomerData IPersistableModel<IspCustomerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<IspCustomerData>(data, options, AzureResourceManagerConnectedCacheContext.Default);

        string IPersistableModel<IspCustomerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<IspCustomerData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
