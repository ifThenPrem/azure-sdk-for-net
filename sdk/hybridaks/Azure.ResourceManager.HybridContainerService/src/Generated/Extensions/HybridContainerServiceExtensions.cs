// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridContainerService.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HybridContainerService. </summary>
    public static partial class HybridContainerServiceExtensions
    {
        private static MockableHybridContainerServiceArmClient GetMockableHybridContainerServiceArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHybridContainerServiceArmClient(client0));
        }

        private static MockableHybridContainerServiceResourceGroupResource GetMockableHybridContainerServiceResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHybridContainerServiceResourceGroupResource(client, resource.Id));
        }

        private static MockableHybridContainerServiceSubscriptionResource GetMockableHybridContainerServiceSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHybridContainerServiceSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a ProvisionedClusterResource along with the instance operations that can be performed on it in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetProvisionedCluster(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ProvisionedClusterResource"/> object. </returns>
        public static ProvisionedClusterResource GetProvisionedCluster(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetProvisionedCluster(scope);
        }

        /// <summary>
        /// Gets an object representing a KubernetesVersionProfileResource along with the instance operations that can be performed on it in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetKubernetesVersionProfile(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="KubernetesVersionProfileResource"/> object. </returns>
        public static KubernetesVersionProfileResource GetKubernetesVersionProfile(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetKubernetesVersionProfile(scope);
        }

        /// <summary>
        /// Gets an object representing a HybridContainerServiceVmSkuResource along with the instance operations that can be performed on it in the ArmClient.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetHybridContainerServiceVmSku(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridContainerServiceVmSkuResource"/> object. </returns>
        public static HybridContainerServiceVmSkuResource GetHybridContainerServiceVmSku(this ArmClient client, ResourceIdentifier scope)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetHybridContainerServiceVmSku(scope);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProvisionedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProvisionedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ProvisionedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetProvisionedClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ProvisionedClusterResource"/> object. </returns>
        public static ProvisionedClusterResource GetProvisionedClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetProvisionedClusterResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProvisionedClusterUpgradeProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProvisionedClusterUpgradeProfileResource.CreateResourceIdentifier" /> to create a <see cref="ProvisionedClusterUpgradeProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetProvisionedClusterUpgradeProfileResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ProvisionedClusterUpgradeProfileResource"/> object. </returns>
        public static ProvisionedClusterUpgradeProfileResource GetProvisionedClusterUpgradeProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetProvisionedClusterUpgradeProfileResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridIdentityMetadataResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridIdentityMetadataResource.CreateResourceIdentifier" /> to create a <see cref="HybridIdentityMetadataResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetHybridIdentityMetadataResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridIdentityMetadataResource"/> object. </returns>
        public static HybridIdentityMetadataResource GetHybridIdentityMetadataResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetHybridIdentityMetadataResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceAgentPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceAgentPoolResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceAgentPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetHybridContainerServiceAgentPoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridContainerServiceAgentPoolResource"/> object. </returns>
        public static HybridContainerServiceAgentPoolResource GetHybridContainerServiceAgentPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetHybridContainerServiceAgentPoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KubernetesVersionProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KubernetesVersionProfileResource.CreateResourceIdentifier" /> to create a <see cref="KubernetesVersionProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetKubernetesVersionProfileResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="KubernetesVersionProfileResource"/> object. </returns>
        public static KubernetesVersionProfileResource GetKubernetesVersionProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetKubernetesVersionProfileResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceVmSkuResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceVmSkuResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceVmSkuResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetHybridContainerServiceVmSkuResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridContainerServiceVmSkuResource"/> object. </returns>
        public static HybridContainerServiceVmSkuResource GetHybridContainerServiceVmSkuResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetHybridContainerServiceVmSkuResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceVirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceVirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceArmClient.GetHybridContainerServiceVirtualNetworkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="HybridContainerServiceVirtualNetworkResource"/> object. </returns>
        public static HybridContainerServiceVirtualNetworkResource GetHybridContainerServiceVirtualNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableHybridContainerServiceArmClient(client).GetHybridContainerServiceVirtualNetworkResource(id);
        }

        /// <summary>
        /// Gets a collection of HybridContainerServiceVirtualNetworkResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceResourceGroupResource.GetHybridContainerServiceVirtualNetworks()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of HybridContainerServiceVirtualNetworkResources and their operations over a HybridContainerServiceVirtualNetworkResource. </returns>
        public static HybridContainerServiceVirtualNetworkCollection GetHybridContainerServiceVirtualNetworks(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHybridContainerServiceResourceGroupResource(resourceGroupResource).GetHybridContainerServiceVirtualNetworks();
        }

        /// <summary>
        /// Gets the Hybrid AKS virtual network
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_Retrieve</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceResourceGroupResource.GetHybridContainerServiceVirtualNetworkAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> Parameter for the name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="virtualNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HybridContainerServiceVirtualNetworkResource>> GetHybridContainerServiceVirtualNetworkAsync(this ResourceGroupResource resourceGroupResource, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableHybridContainerServiceResourceGroupResource(resourceGroupResource).GetHybridContainerServiceVirtualNetworkAsync(virtualNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the Hybrid AKS virtual network
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_Retrieve</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceResourceGroupResource.GetHybridContainerServiceVirtualNetwork(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> Parameter for the name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="virtualNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetwork(this ResourceGroupResource resourceGroupResource, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableHybridContainerServiceResourceGroupResource(resourceGroupResource).GetHybridContainerServiceVirtualNetwork(virtualNetworkName, cancellationToken);
        }

        /// <summary>
        /// Lists the Hybrid AKS virtual networks by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceSubscriptionResource.GetHybridContainerServiceVirtualNetworks(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="HybridContainerServiceVirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetworksAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridContainerServiceSubscriptionResource(subscriptionResource).GetHybridContainerServiceVirtualNetworksAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the Hybrid AKS virtual networks by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridContainerService/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>virtualNetworks_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVirtualNetworkResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHybridContainerServiceSubscriptionResource.GetHybridContainerServiceVirtualNetworks(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="HybridContainerServiceVirtualNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HybridContainerServiceVirtualNetworkResource> GetHybridContainerServiceVirtualNetworks(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableHybridContainerServiceSubscriptionResource(subscriptionResource).GetHybridContainerServiceVirtualNetworks(cancellationToken);
        }
    }
}
