// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class VpnClientConnectionHealthDetailListResultOperationSource : IOperationSource<VpnClientConnectionHealthDetailListResult>
    {
        VpnClientConnectionHealthDetailListResult IOperationSource<VpnClientConnectionHealthDetailListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return VpnClientConnectionHealthDetailListResult.DeserializeVpnClientConnectionHealthDetailListResult(document.RootElement);
        }

        async ValueTask<VpnClientConnectionHealthDetailListResult> IOperationSource<VpnClientConnectionHealthDetailListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return VpnClientConnectionHealthDetailListResult.DeserializeVpnClientConnectionHealthDetailListResult(document.RootElement);
        }
    }
}
