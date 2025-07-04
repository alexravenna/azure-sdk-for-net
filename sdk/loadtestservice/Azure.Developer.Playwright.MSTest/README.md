# Azure Playwright MSTest client library for .NET

Azure Playwright is a fully managed service that uses the cloud to enable you to run Playwright tests with much higher parallelization across different operating system-browser combinations simultaneously. This means faster test runs with broader scenario coverage, which helps speed up delivery of features without sacrificing quality. The service also enables you to publish test results and related artifacts to the service and view them in the service portal enabling faster and easier troubleshooting. With Azure Playwright, you can release features faster and more confidently.

Ready to get started? Jump into our [quickstart guide](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/loadtestservice/Azure.Developer.Playwright.MSTest/README.md#getting-started)!

## Useful links

-   [Quickstart: Run end-to-end tests at scale](https://aka.ms/mpt/quickstart)
-   [View Azure Playwright service demo](https://youtu.be/GenC1jAeTZE)
-   [Documentation](https://aka.ms/mpt/docs)
-   [Pricing](https://aka.ms/mpt/pricing)
-   [Share feedback](https://aka.ms/mpt/feedback)

## Getting started

### Install the package

Install the client library for .NET with [NuGet](https://www.nuget.org/):

```dotnetcli
dotnet add package Azure.Developer.Playwright.MSTest --prerelease
```

### Prerequisites

-   An [Azure subscription](https://azure.microsoft.com/free/dotnet/)
-   Your Azure account must be assigned the [Owner](https://learn.microsoft.com/azure/role-based-access-control/built-in-roles#owner), [Contributor](https://learn.microsoft.com/azure/role-based-access-control/built-in-roles#contributor), or one of the [classic administrator roles](https://learn.microsoft.com/azure/role-based-access-control/rbac-and-directory-admin-roles#classic-subscription-administrator-roles).

### Authenticate the client

To learn more about options for Microsoft Entra Id authentication, refer to [Azure.Identity credentials](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity#credentials).

#### Create a Workspace

1. Sign in to the [Playwright portal](https://aka.ms/mpt/portal) with your Azure account.

2. Create the Workspace

    ![Create new workspace](https://github.com/microsoft/playwright-testing-service/assets/12104064/d571e86b-9d43-48ac-a2b7-63afb9bb86a8)

    | Field                  | Description                                                                                           |
    | ---------------------- | ----------------------------------------------------------------------------------------------------- |
    | **Workspace Name**     | A unique name to identify your workspace.<BR>The name can't contain special characters or whitespace. |
    | **Azure Subscription** | Select an Azure subscription where you want to create the workspace.                                  |
    | **Region**             | This is where test run data will be stored for your workspace.                                        |

> [!NOTE]
> If you don't see this screen, select an existing workspace and go to the next section.

    ```

### Set up Azure Playwright

Create a file `PlaywrightServiceSetup.cs` in the root directory with the below content

```C# Snippet:MSTest_Sample1_SimpleSetup
using System.Threading.Tasks;
using Azure.Developer.Playwright.MSTest;
using Azure.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlaywrightService.SampleTests; // Remember to change this as per your project namespace

public class PlaywrightServiceMSTestSetup
{
    private static PlaywrightServiceBrowserMSTest playwrightClient = null!;

    [AssemblyInitialize]
    public static async Task AssemblyInitialize(TestContext testContext)
    {
        playwrightClient = new PlaywrightServiceBrowserMSTest(context: testContext, credential: new DefaultAzureCredential());
        await playwrightClient.InitializeAsync();
    }

    [AssemblyCleanup]
    public static async Task AssemblyCleanup()
    {
        await playwrightClient.DisposeAsync();
    }
}
```

> [!NOTE]
> Make sure your project uses `Microsoft.Playwright.MSTest` version 1.37 or above.

### Obtain region endpoint

1. In the [Playwright portal](https://aka.ms/mpt/portal), copy the command under **Add region endpoint in your set up**.

    ![Set workspace endpoint](https://github.com/microsoft/playwright-testing-service/assets/12104064/d81ca629-2b23-4d34-8b70-67b6f7061a83)

    The endpoint URL corresponds to the workspace region. You might see a different endpoint URL in the Playwright portal, depending on the region you selected when creating the workspace.

### Set up environment

Ensure that the `PLAYWRIGHT_SERVICE_URL` that you obtained in previous step is available in your environment.

### Run the tests

Run Playwright tests against browsers managed by the service using the configuration you created above.

```dotnetcli
dotnet test
```

## Key concepts

Key concepts of the Azure Playwright MSTest SDK for .NET can be found [here](https://aka.ms/mpt/what-is-mpt)

## Examples

Code samples for using this SDK can be found in the following locations

-   [.NET Azure Playwright MSTest Library Code Samples](https://aka.ms/mpt/sample)

## Troubleshooting

-   File an issue via [GitHub Issues](https://github.com/Azure/azure-sdk-for-net/issues).
-   Check [previous questions](https://stackoverflow.com/questions/tagged/azure+.net) or ask new ones on Stack Overflow using Azure and .NET tags.

## Next steps

-   Run tests in a [CI/CD pipeline.](https://aka.ms/mpt/configure-pipeline)

-   Learn how to [manage access](https://aka.ms/mpt/manage-access) to the created workspace.

-   Experiment with different number of workers to [determine the optimal configuration of your test suite](https://aka.ms/mpt/parallelism).

## Contributing

This project welcomes contributions and suggestions. Most contributions require
you to agree to a Contributor License Agreement (CLA) declaring that you have
the right to, and actually do, grant us the rights to use your contribution. For
details, visit [cla.microsoft.com][cla].

This project has adopted the [Microsoft Open Source Code of Conduct][coc].
For more information see the [Code of Conduct FAQ][coc_faq] or contact
[opencode@microsoft.com][coc_contact] with any additional questions or comments.

![Impressions](https://azure-sdk-impressions.azurewebsites.net/api/impressions/azure-sdk-for-net/sdk/loadtestservice/Azure.Developer.Playwright.MSTest/README.png)
