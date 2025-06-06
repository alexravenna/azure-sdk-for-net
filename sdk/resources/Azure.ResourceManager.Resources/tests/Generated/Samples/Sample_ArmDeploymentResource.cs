// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_ArmDeploymentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateDeploymentAtAGivenScope()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2025-04-01/examples/PutDeploymentAtScope.json
            // this example is just showing the usage of "Deployments_CreateOrUpdateAtScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmDeploymentResource created on azure
            // for more information of creating ArmDeploymentResource, please refer to the document of ArmDeploymentResource
            string scope = "providers/Microsoft.Management/managementGroups/my-management-group-id";
            string deploymentName = "my-deployment";
            ResourceIdentifier armDeploymentResourceId = ArmDeploymentResource.CreateResourceIdentifier(scope, deploymentName);
            ArmDeploymentResource armDeployment = client.GetArmDeploymentResource(armDeploymentResourceId);

            // invoke the operation
            ArmDeploymentContent content = new ArmDeploymentContent(new ArmDeploymentProperties(ArmDeploymentMode.Incremental)
            {
                TemplateLink = new ArmDeploymentTemplateLink
                {
                    Uri = new Uri("https://example.com/exampleTemplate.json"),
                },
                Parameters = BinaryData.FromObjectAsJson(new object()),
            })
            {
                Location = new AzureLocation("eastus"),
                Tags =
{
["tagKey1"] = "tag-value-1",
["tagKey2"] = "tag-value-2"
},
            };
            ArmOperation<ArmDeploymentResource> lro = await armDeployment.UpdateAsync(WaitUntil.Completed, content);
            ArmDeploymentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Validate_ValidatesATemplateAtScope()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2025-04-01/examples/PostDeploymentValidateOnScope.json
            // this example is just showing the usage of "Deployments_ValidateAtScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmDeploymentResource created on azure
            // for more information of creating ArmDeploymentResource, please refer to the document of ArmDeploymentResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/my-resource-group";
            string deploymentName = "my-deployment";
            ResourceIdentifier armDeploymentResourceId = ArmDeploymentResource.CreateResourceIdentifier(scope, deploymentName);
            ArmDeploymentResource armDeployment = client.GetArmDeploymentResource(armDeploymentResourceId);

            // invoke the operation
            ArmDeploymentContent content = new ArmDeploymentContent(new ArmDeploymentProperties(ArmDeploymentMode.Incremental)
            {
                TemplateLink = new ArmDeploymentTemplateLink
                {
                    Uri = new Uri("https://example.com/exampleTemplate.json"),
                    QueryString = "sv=2019-02-02&st=2019-04-29T22%3A18%3A26Z&se=2019-04-30T02%3A23%3A26Z&sr=b&sp=rw&sip=168.1.5.60-168.1.5.70&spr=https&sig=xxxxxxxx0xxxxxxxxxxxxx%2bxxxxxxxxxxxxxxxxxxxx%3d",
                },
                Parameters = BinaryData.FromObjectAsJson(new object()),
            });
            ArmOperation<ArmDeploymentValidateResult> lro = await armDeployment.ValidateAsync(WaitUntil.Completed, content);
            ArmDeploymentValidateResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task WhatIf_PredictTemplateChangesAtTenantScope()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2025-04-01/examples/PostDeploymentWhatIfOnTenant.json
            // this example is just showing the usage of "Deployments_WhatIfAtTenantScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmDeploymentResource created on azure
            // for more information of creating ArmDeploymentResource, please refer to the document of ArmDeploymentResource
            string scope = $"/";
            string deploymentName = "exampleDeploymentName";
            ResourceIdentifier armDeploymentResourceId = ArmDeploymentResource.CreateResourceIdentifier(scope, deploymentName);
            ArmDeploymentResource armDeployment = client.GetArmDeploymentResource(armDeploymentResourceId);

            // invoke the operation
            ArmDeploymentWhatIfContent content = new ArmDeploymentWhatIfContent(new ArmDeploymentWhatIfProperties(ArmDeploymentMode.Incremental)
            {
                TemplateLink = new ArmDeploymentTemplateLink
                {
                    Uri = new Uri("https://example.com/exampleTemplate.json"),
                },
                Parameters = BinaryData.FromObjectAsJson(new object()),
            })
            {
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<WhatIfOperationResult> lro = await armDeployment.WhatIfAsync(WaitUntil.Completed, content);
            WhatIfOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task WhatIf_PredictTemplateChangesAtManagementGroupScope()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2025-04-01/examples/PostDeploymentWhatIfOnManagementGroup.json
            // this example is just showing the usage of "Deployments_WhatIfAtManagementGroupScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmDeploymentResource created on azure
            // for more information of creating ArmDeploymentResource, please refer to the document of ArmDeploymentResource
            string groupId = "myManagementGruop";
            string scope = $"/providers/Microsoft.Management/managementGroups/{groupId}";
            string deploymentName = "exampleDeploymentName";
            ResourceIdentifier armDeploymentResourceId = ArmDeploymentResource.CreateResourceIdentifier(scope, deploymentName);
            ArmDeploymentResource armDeployment = client.GetArmDeploymentResource(armDeploymentResourceId);

            // invoke the operation
            ArmDeploymentWhatIfContent content = new ArmDeploymentWhatIfContent(new ArmDeploymentWhatIfProperties(ArmDeploymentMode.Incremental)
            {
                TemplateLink = new ArmDeploymentTemplateLink
                {
                    Uri = new Uri("https://example.com/exampleTemplate.json"),
                },
                Parameters = BinaryData.FromObjectAsJson(new object()),
            })
            {
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<WhatIfOperationResult> lro = await armDeployment.WhatIfAsync(WaitUntil.Completed, content);
            WhatIfOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task WhatIf_PredictTemplateChangesAtSubscriptionScope()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2025-04-01/examples/PostDeploymentWhatIfOnSubscription.json
            // this example is just showing the usage of "Deployments_WhatIfAtSubscriptionScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmDeploymentResource created on azure
            // for more information of creating ArmDeploymentResource, please refer to the document of ArmDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000001";
            string scope = $"/subscriptions/{subscriptionId}";
            string deploymentName = "my-deployment";
            ResourceIdentifier armDeploymentResourceId = ArmDeploymentResource.CreateResourceIdentifier(scope, deploymentName);
            ArmDeploymentResource armDeployment = client.GetArmDeploymentResource(armDeploymentResourceId);

            // invoke the operation
            ArmDeploymentWhatIfContent content = new ArmDeploymentWhatIfContent(new ArmDeploymentWhatIfProperties(ArmDeploymentMode.Incremental)
            {
                TemplateLink = new ArmDeploymentTemplateLink
                {
                    Uri = new Uri("https://example.com/exampleTemplate.json"),
                },
                Parameters = BinaryData.FromObjectAsJson(new object()),
            })
            {
                Location = new AzureLocation("westus"),
            };
            ArmOperation<WhatIfOperationResult> lro = await armDeployment.WhatIfAsync(WaitUntil.Completed, content);
            WhatIfOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task WhatIf_PredictTemplateChangesAtResourceGroupScope()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2025-04-01/examples/PostDeploymentWhatIfOnResourceGroup.json
            // this example is just showing the usage of "Deployments_WhatIf" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmDeploymentResource created on azure
            // for more information of creating ArmDeploymentResource, please refer to the document of ArmDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000001";
            string resourceGroupName = "my-resource-group";
            string scope = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}";
            string deploymentName = "my-deployment";
            ResourceIdentifier armDeploymentResourceId = ArmDeploymentResource.CreateResourceIdentifier(scope, deploymentName);
            ArmDeploymentResource armDeployment = client.GetArmDeploymentResource(armDeploymentResourceId);

            // invoke the operation
            ArmDeploymentWhatIfContent content = new ArmDeploymentWhatIfContent(new ArmDeploymentWhatIfProperties(ArmDeploymentMode.Incremental)
            {
                TemplateLink = new ArmDeploymentTemplateLink
                {
                    Uri = new Uri("https://example.com/exampleTemplate.json"),
                },
                Parameters = BinaryData.FromObjectAsJson(new object()),
            });
            ArmOperation<WhatIfOperationResult> lro = await armDeployment.WhatIfAsync(WaitUntil.Completed, content);
            WhatIfOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
