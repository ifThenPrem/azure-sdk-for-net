// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHybridContainerServiceArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceArmClient"/> class for mocking. </summary>
        protected MockableHybridContainerServiceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridContainerServiceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHybridContainerServiceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a ProvisionedClusterResource along with the instance operations that can be performed on it in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> Returns a <see cref="ProvisionedClusterResource"/> object. </returns>
        public virtual ProvisionedClusterResource GetProvisionedCluster(ResourceIdentifier scope)
        {
            return new ProvisionedClusterResource(Client, scope.AppendProviderResource("Microsoft.HybridContainerService", "provisionedClusterInstances", "default"));
        }

        /// <summary> Gets an object representing a KubernetesVersionProfileResource along with the instance operations that can be performed on it in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> Returns a <see cref="KubernetesVersionProfileResource"/> object. </returns>
        public virtual KubernetesVersionProfileResource GetKubernetesVersionProfile(ResourceIdentifier scope)
        {
            return new KubernetesVersionProfileResource(Client, scope.AppendProviderResource("Microsoft.HybridContainerService", "kubernetesVersions", "default"));
        }

        /// <summary> Gets an object representing a HybridContainerServiceVmSkuResource along with the instance operations that can be performed on it in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> Returns a <see cref="HybridContainerServiceVmSkuResource"/> object. </returns>
        public virtual HybridContainerServiceVmSkuResource GetHybridContainerServiceVmSku(ResourceIdentifier scope)
        {
            return new HybridContainerServiceVmSkuResource(Client, scope.AppendProviderResource("Microsoft.HybridContainerService", "skus", "default"));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProvisionedClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProvisionedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ProvisionedClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProvisionedClusterResource"/> object. </returns>
        public virtual ProvisionedClusterResource GetProvisionedClusterResource(ResourceIdentifier id)
        {
            ProvisionedClusterResource.ValidateResourceId(id);
            return new ProvisionedClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProvisionedClusterUpgradeProfileResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProvisionedClusterUpgradeProfileResource.CreateResourceIdentifier" /> to create a <see cref="ProvisionedClusterUpgradeProfileResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProvisionedClusterUpgradeProfileResource"/> object. </returns>
        public virtual ProvisionedClusterUpgradeProfileResource GetProvisionedClusterUpgradeProfileResource(ResourceIdentifier id)
        {
            ProvisionedClusterUpgradeProfileResource.ValidateResourceId(id);
            return new ProvisionedClusterUpgradeProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridIdentityMetadataResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridIdentityMetadataResource.CreateResourceIdentifier" /> to create a <see cref="HybridIdentityMetadataResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridIdentityMetadataResource"/> object. </returns>
        public virtual HybridIdentityMetadataResource GetHybridIdentityMetadataResource(ResourceIdentifier id)
        {
            HybridIdentityMetadataResource.ValidateResourceId(id);
            return new HybridIdentityMetadataResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceAgentPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceAgentPoolResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceAgentPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridContainerServiceAgentPoolResource"/> object. </returns>
        public virtual HybridContainerServiceAgentPoolResource GetHybridContainerServiceAgentPoolResource(ResourceIdentifier id)
        {
            HybridContainerServiceAgentPoolResource.ValidateResourceId(id);
            return new HybridContainerServiceAgentPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KubernetesVersionProfileResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KubernetesVersionProfileResource.CreateResourceIdentifier" /> to create a <see cref="KubernetesVersionProfileResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KubernetesVersionProfileResource"/> object. </returns>
        public virtual KubernetesVersionProfileResource GetKubernetesVersionProfileResource(ResourceIdentifier id)
        {
            KubernetesVersionProfileResource.ValidateResourceId(id);
            return new KubernetesVersionProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceVmSkuResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceVmSkuResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceVmSkuResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridContainerServiceVmSkuResource"/> object. </returns>
        public virtual HybridContainerServiceVmSkuResource GetHybridContainerServiceVmSkuResource(ResourceIdentifier id)
        {
            HybridContainerServiceVmSkuResource.ValidateResourceId(id);
            return new HybridContainerServiceVmSkuResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceVirtualNetworkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceVirtualNetworkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridContainerServiceVirtualNetworkResource"/> object. </returns>
        public virtual HybridContainerServiceVirtualNetworkResource GetHybridContainerServiceVirtualNetworkResource(ResourceIdentifier id)
        {
            HybridContainerServiceVirtualNetworkResource.ValidateResourceId(id);
            return new HybridContainerServiceVirtualNetworkResource(Client, id);
        }
    }
}
