// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CognitiveServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CognitiveServicesConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAccountConnection()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/AccountConnection/get.json
            // this example is just showing the usage of "AccountConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesConnectionResource created on azure
            // for more information of creating CognitiveServicesConnectionResource, please refer to the document of CognitiveServicesConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string accountName = "account-1";
            string connectionName = "connection-1";
            ResourceIdentifier cognitiveServicesConnectionResourceId = CognitiveServicesConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, connectionName);
            CognitiveServicesConnectionResource cognitiveServicesConnection = client.GetCognitiveServicesConnectionResource(cognitiveServicesConnectionResourceId);

            // invoke the operation
            CognitiveServicesConnectionResource result = await cognitiveServicesConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAccountConnection()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/AccountConnection/delete.json
            // this example is just showing the usage of "AccountConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesConnectionResource created on azure
            // for more information of creating CognitiveServicesConnectionResource, please refer to the document of CognitiveServicesConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup-1";
            string accountName = "account-1";
            string connectionName = "connection-1";
            ResourceIdentifier cognitiveServicesConnectionResourceId = CognitiveServicesConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, connectionName);
            CognitiveServicesConnectionResource cognitiveServicesConnection = client.GetCognitiveServicesConnectionResource(cognitiveServicesConnectionResourceId);

            // invoke the operation
            await cognitiveServicesConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAccountConnection()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/examples/AccountConnection/update.json
            // this example is just showing the usage of "AccountConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesConnectionResource created on azure
            // for more information of creating CognitiveServicesConnectionResource, please refer to the document of CognitiveServicesConnectionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string accountName = "account-1";
            string connectionName = "connection-1";
            ResourceIdentifier cognitiveServicesConnectionResourceId = CognitiveServicesConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, connectionName);
            CognitiveServicesConnectionResource cognitiveServicesConnection = client.GetCognitiveServicesConnectionResource(cognitiveServicesConnectionResourceId);

            // invoke the operation
            CognitiveServicesConnectionPatch patch = new CognitiveServicesConnectionPatch
            {
                Properties = new AccessKeyAuthTypeConnectionProperties
                {
                    Credentials = new CognitiveServicesConnectionAccessKey
                    {
                        AccessKeyId = "some_string",
                        SecretAccessKey = "some_string",
                    },
                    Category = CognitiveServicesConnectionCategory.AdlsGen2,
                    ExpiryOn = DateTimeOffset.Parse("2020-01-01T00:00:00Z"),
                    Metadata = { },
                    Target = "some_string",
                },
            };
            CognitiveServicesConnectionResource result = await cognitiveServicesConnection.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
