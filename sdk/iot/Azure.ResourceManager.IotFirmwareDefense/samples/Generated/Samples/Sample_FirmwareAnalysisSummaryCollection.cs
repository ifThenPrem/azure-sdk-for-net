// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense;
using Azure.ResourceManager.IotFirmwareDefense.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Samples
{
    public partial class Sample_FirmwareAnalysisSummaryCollection
    {
        // Summaries_ListByFirmware_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SummariesListByFirmwareMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation and iterate over the result
            await foreach (FirmwareAnalysisSummaryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareAnalysisSummaryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Summaries_ListByFirmware_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SummariesListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation and iterate over the result
            await foreach (FirmwareAnalysisSummaryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareAnalysisSummaryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            FirmwareAnalysisSummaryResource result = await collection.GetAsync(summaryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareAnalysisSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            bool result = await collection.ExistsAsync(summaryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            NullableResponse<FirmwareAnalysisSummaryResource> response = await collection.GetIfExistsAsync(summaryName);
            FirmwareAnalysisSummaryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareAnalysisSummaryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            FirmwareAnalysisSummaryResource result = await collection.GetAsync(summaryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareAnalysisSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            bool result = await collection.ExistsAsync(summaryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/stable/2024-01-10/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // get the collection of this FirmwareAnalysisSummaryResource
            FirmwareAnalysisSummaryCollection collection = iotFirmware.GetFirmwareAnalysisSummaries();

            // invoke the operation
            FirmwareAnalysisSummaryName summaryName = FirmwareAnalysisSummaryName.Firmware;
            NullableResponse<FirmwareAnalysisSummaryResource> response = await collection.GetIfExistsAsync(summaryName);
            FirmwareAnalysisSummaryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareAnalysisSummaryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
