// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceApiOperationPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceApiOperationPolicy.json
            // this example is just showing the usage of "WorkspaceApiOperationPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationPolicyResource, please refer to the document of ServiceWorkspaceApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "5600b539c53f5b0062040001";
            string operationId = "5600b53ac53f5b0062080006";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiOperationPolicyResourceId = ServiceWorkspaceApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId, policyId);
            ServiceWorkspaceApiOperationPolicyResource serviceWorkspaceApiOperationPolicy = client.GetServiceWorkspaceApiOperationPolicyResource(serviceWorkspaceApiOperationPolicyResourceId);

            // invoke the operation
            ServiceWorkspaceApiOperationPolicyResource result = await serviceWorkspaceApiOperationPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteWorkspaceApiOperationPolicy.json
            // this example is just showing the usage of "WorkspaceApiOperationPolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationPolicyResource, please refer to the document of ServiceWorkspaceApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "testapi";
            string operationId = "testoperation";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiOperationPolicyResourceId = ServiceWorkspaceApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId, policyId);
            ServiceWorkspaceApiOperationPolicyResource serviceWorkspaceApiOperationPolicy = client.GetServiceWorkspaceApiOperationPolicyResource(serviceWorkspaceApiOperationPolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceApiOperationPolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspaceApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceApiOperationPolicy.json
            // this example is just showing the usage of "WorkspaceApiOperationPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationPolicyResource, please refer to the document of ServiceWorkspaceApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "5600b57e7e8880006a040001";
            string operationId = "5600b57e7e8880006a080001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiOperationPolicyResourceId = ServiceWorkspaceApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId, policyId);
            ServiceWorkspaceApiOperationPolicyResource serviceWorkspaceApiOperationPolicy = client.GetServiceWorkspaceApiOperationPolicyResource(serviceWorkspaceApiOperationPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData
            {
                Value = "<policies> <inbound /> <backend>    <forward-request />  </backend>  <outbound /></policies>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ServiceWorkspaceApiOperationPolicyResource> lro = await serviceWorkspaceApiOperationPolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ServiceWorkspaceApiOperationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadWorkspaceApiOperationPolicy.json
            // this example is just showing the usage of "WorkspaceApiOperationPolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationPolicyResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationPolicyResource, please refer to the document of ServiceWorkspaceApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "5600b539c53f5b0062040001";
            string operationId = "5600b53ac53f5b0062080006";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier serviceWorkspaceApiOperationPolicyResourceId = ServiceWorkspaceApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId, policyId);
            ServiceWorkspaceApiOperationPolicyResource serviceWorkspaceApiOperationPolicy = client.GetServiceWorkspaceApiOperationPolicyResource(serviceWorkspaceApiOperationPolicyResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceApiOperationPolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
