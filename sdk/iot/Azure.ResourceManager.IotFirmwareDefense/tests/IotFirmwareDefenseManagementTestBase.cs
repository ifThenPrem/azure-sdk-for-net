﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.IotFirmwareDefense.Tests
{
    public class IotFirmwareDefenseManagementTestBase : ManagementRecordedTestBase<IotFirmwareDefenseManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected SubscriptionResource DefaultSubscription { get; private set; }

        protected IotFirmwareDefenseManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected IotFirmwareDefenseManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }
        protected async Task<ResourceGroupResource> DeleteResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            var lro = await subscription.GetResourceGroupAsync(rgName);
            return lro.Value;
        }

        protected async Task<FirmwareAnalysisWorkspaceResource> CreateWorkspace(ResourceGroupResource rg)
        {
            var _ = await rg.GetFirmwareAnalysisWorkspaces().CreateOrUpdateAsync(
                WaitUntil.Completed,
                Recording.GenerateAssetName("resource"),
                new FirmwareAnalysisWorkspaceData(AzureLocation.EastUS));
            return _.Value;
        }

        protected async Task<IotFirmwareResource> CreateFirmware(FirmwareAnalysisWorkspaceResource workspace, IotFirmwareData firmwareData)
        {
            var _ = await workspace.GetIotFirmwares().CreateOrUpdateAsync(
                WaitUntil.Completed,
                Recording.GenerateAssetName("resource"),
                firmwareData);
            return _.Value;
        }
    }
}
