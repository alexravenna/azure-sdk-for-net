// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesBackup.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupProtectionContainerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetProtectionContainerDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2025-02-01/examples/AzureWorkload/ProtectionContainers_Get.json
            // this example is just showing the usage of "ProtectionContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testRg";
            string vaultName = "testVault";
            string fabricName = "Azure";
            string containerName = "VMAppContainer;Compute;testRG;testSQL";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // invoke the operation
            BackupProtectionContainerResource result = await backupProtectionContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectionContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_UnregisterProtectionContainer()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2025-02-01/examples/AzureWorkload/ProtectionContainers_Unregister.json
            // this example is just showing the usage of "ProtectionContainers_Unregister" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testRg";
            string vaultName = "testVault";
            string fabricName = "Azure";
            string containerName = "storagecontainer;Storage;test-rg;teststorage";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // invoke the operation
            await backupProtectionContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RegisterAzureStorageProtectionContainers()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2025-02-01/examples/AzureStorage/ProtectionContainers_Register.json
            // this example is just showing the usage of "ProtectionContainers_Register" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SwaggerTestRg";
            string vaultName = "swaggertestvault";
            string fabricName = "Azure";
            string containerName = "StorageContainer;Storage;SwaggerTestRg;swaggertestsa";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // invoke the operation
            BackupProtectionContainerData data = new BackupProtectionContainerData(default)
            {
                Properties = new StorageContainer
                {
                    SourceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/SwaggerTestRg/providers/Microsoft.Storage/storageAccounts/swaggertestsa"),
                    AcquireStorageAccountLock = AcquireStorageAccountLock.Acquire,
                    FriendlyName = "swaggertestsa",
                    BackupManagementType = BackupManagementType.AzureStorage,
                },
            };
            ArmOperation<BackupProtectionContainerResource> lro = await backupProtectionContainer.UpdateAsync(WaitUntil.Completed, data);
            BackupProtectionContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectionContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Inquire_InquireAzureStorageProtectionContainers()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2025-02-01/examples/AzureStorage/ProtectionContainers_Inquire.json
            // this example is just showing the usage of "ProtectionContainers_Inquire" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string vaultName = "testvault";
            string fabricName = "Azure";
            string containerName = "storagecontainer;Storage;test-rg;teststorage";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // invoke the operation
            await backupProtectionContainer.InquireAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBackupWorkloadItems_ListWorkloadItemsInContainer()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2025-02-01/examples/AzureWorkload/BackupWorkloadItems_List.json
            // this example is just showing the usage of "BackupWorkloadItems_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testRg";
            string vaultName = "suchandr-seacan-rsv";
            string fabricName = "Azure";
            string containerName = "VMAppContainer;Compute;bvtdtestag;sqlserver-1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // invoke the operation and iterate over the result
            string filter = "backupManagementType eq 'AzureWorkload'";
            await foreach (WorkloadItemResource item in backupProtectionContainer.GetBackupWorkloadItemsAsync(filter: filter))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
