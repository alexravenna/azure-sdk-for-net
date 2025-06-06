// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class Yield : IJsonModel<Yield>
    {
        internal Yield() => throw null;

        void IJsonModel<Yield>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        Yield IJsonModel<Yield>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual Yield JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<Yield>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        Yield IPersistableModel<Yield>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual Yield PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<Yield>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="yield"> The <see cref="Yield"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(Yield @yield) => throw null;
    }
}
