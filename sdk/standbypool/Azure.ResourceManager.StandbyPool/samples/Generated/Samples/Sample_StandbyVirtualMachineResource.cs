// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyVirtualMachineResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StandbyVirtualMachinesGet()
        {
            // Generated from example definition: 2025-03-01/StandbyVirtualMachines_Get.json
            // this example is just showing the usage of "StandbyVirtualMachineResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachineResource created on azure
            // for more information of creating StandbyVirtualMachineResource, please refer to the document of StandbyVirtualMachineResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            string standbyVirtualMachineName = "virtualMachine";
            ResourceIdentifier standbyVirtualMachineResourceId = StandbyVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName, standbyVirtualMachineName);
            StandbyVirtualMachineResource standbyVirtualMachine = client.GetStandbyVirtualMachineResource(standbyVirtualMachineResourceId);

            // invoke the operation
            StandbyVirtualMachineResource result = await standbyVirtualMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
