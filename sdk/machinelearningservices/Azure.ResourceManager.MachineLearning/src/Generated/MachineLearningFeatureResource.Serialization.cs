// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningFeatureResource : IJsonModel<MachineLearningFeatureData>
    {
        private static MachineLearningFeatureData s_dataDeserializationInstance;
        private static MachineLearningFeatureData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MachineLearningFeatureData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningFeatureData>)Data).Write(writer, options);

        MachineLearningFeatureData IJsonModel<MachineLearningFeatureData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningFeatureData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningFeatureData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningFeatureData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningFeatureData IPersistableModel<MachineLearningFeatureData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningFeatureData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningFeatureData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningFeatureData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
