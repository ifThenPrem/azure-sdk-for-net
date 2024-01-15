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
using Azure.ResourceManager.DigitalTwins.Mocking;
using Azure.ResourceManager.DigitalTwins.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DigitalTwins. </summary>
    public static partial class DigitalTwinsExtensions
    {
        private static MockableDigitalTwinsArmClient GetMockableDigitalTwinsArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDigitalTwinsArmClient(client0));
        }

        private static MockableDigitalTwinsResourceGroupResource GetMockableDigitalTwinsResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDigitalTwinsResourceGroupResource(client, resource.Id));
        }

        private static MockableDigitalTwinsSubscriptionResource GetMockableDigitalTwinsSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDigitalTwinsSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DigitalTwinsDescriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DigitalTwinsDescriptionResource.CreateResourceIdentifier" /> to create a <see cref="DigitalTwinsDescriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsArmClient.GetDigitalTwinsDescriptionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DigitalTwinsDescriptionResource"/> object. </returns>
        public static DigitalTwinsDescriptionResource GetDigitalTwinsDescriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDigitalTwinsArmClient(client).GetDigitalTwinsDescriptionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DigitalTwinsEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DigitalTwinsEndpointResource.CreateResourceIdentifier" /> to create a <see cref="DigitalTwinsEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsArmClient.GetDigitalTwinsEndpointResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DigitalTwinsEndpointResource"/> object. </returns>
        public static DigitalTwinsEndpointResource GetDigitalTwinsEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDigitalTwinsArmClient(client).GetDigitalTwinsEndpointResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DigitalTwinsPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DigitalTwinsPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="DigitalTwinsPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsArmClient.GetDigitalTwinsPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DigitalTwinsPrivateLinkResource"/> object. </returns>
        public static DigitalTwinsPrivateLinkResource GetDigitalTwinsPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDigitalTwinsArmClient(client).GetDigitalTwinsPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DigitalTwinsPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DigitalTwinsPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DigitalTwinsPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsArmClient.GetDigitalTwinsPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DigitalTwinsPrivateEndpointConnectionResource"/> object. </returns>
        public static DigitalTwinsPrivateEndpointConnectionResource GetDigitalTwinsPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDigitalTwinsArmClient(client).GetDigitalTwinsPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TimeSeriesDatabaseConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TimeSeriesDatabaseConnectionResource.CreateResourceIdentifier" /> to create a <see cref="TimeSeriesDatabaseConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsArmClient.GetTimeSeriesDatabaseConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TimeSeriesDatabaseConnectionResource"/> object. </returns>
        public static TimeSeriesDatabaseConnectionResource GetTimeSeriesDatabaseConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDigitalTwinsArmClient(client).GetTimeSeriesDatabaseConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of DigitalTwinsDescriptionResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsResourceGroupResource.GetDigitalTwinsDescriptions()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DigitalTwinsDescriptionResources and their operations over a DigitalTwinsDescriptionResource. </returns>
        public static DigitalTwinsDescriptionCollection GetDigitalTwinsDescriptions(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDigitalTwinsResourceGroupResource(resourceGroupResource).GetDigitalTwinsDescriptions();
        }

        /// <summary>
        /// Get DigitalTwinsInstances resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsResourceGroupResource.GetDigitalTwinsDescriptionAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DigitalTwinsDescriptionResource>> GetDigitalTwinsDescriptionAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDigitalTwinsResourceGroupResource(resourceGroupResource).GetDigitalTwinsDescriptionAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get DigitalTwinsInstances resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsResourceGroupResource.GetDigitalTwinsDescription(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the DigitalTwinsInstance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DigitalTwinsDescriptionResource> GetDigitalTwinsDescription(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDigitalTwinsResourceGroupResource(resourceGroupResource).GetDigitalTwinsDescription(resourceName, cancellationToken);
        }

        /// <summary>
        /// Get all the DigitalTwinsInstances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/digitalTwinsInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsSubscriptionResource.GetDigitalTwinsDescriptions(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DigitalTwinsDescriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DigitalTwinsDescriptionResource> GetDigitalTwinsDescriptionsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDigitalTwinsSubscriptionResource(subscriptionResource).GetDigitalTwinsDescriptionsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all the DigitalTwinsInstances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/digitalTwinsInstances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsSubscriptionResource.GetDigitalTwinsDescriptions(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DigitalTwinsDescriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DigitalTwinsDescriptionResource> GetDigitalTwinsDescriptions(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDigitalTwinsSubscriptionResource(subscriptionResource).GetDigitalTwinsDescriptions(cancellationToken);
        }

        /// <summary>
        /// Check if a DigitalTwinsInstance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsSubscriptionResource.CheckDigitalTwinsNameAvailability(AzureLocation,DigitalTwinsNameContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of DigitalTwinsInstance. </param>
        /// <param name="content"> Set the name parameter in the DigitalTwinsInstanceCheckName structure to the name of the DigitalTwinsInstance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<DigitalTwinsNameResult>> CheckDigitalTwinsNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, DigitalTwinsNameContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDigitalTwinsSubscriptionResource(subscriptionResource).CheckDigitalTwinsNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if a DigitalTwinsInstance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DigitalTwins/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwins_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDigitalTwinsSubscriptionResource.CheckDigitalTwinsNameAvailability(AzureLocation,DigitalTwinsNameContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of DigitalTwinsInstance. </param>
        /// <param name="content"> Set the name parameter in the DigitalTwinsInstanceCheckName structure to the name of the DigitalTwinsInstance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<DigitalTwinsNameResult> CheckDigitalTwinsNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, DigitalTwinsNameContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDigitalTwinsSubscriptionResource(subscriptionResource).CheckDigitalTwinsNameAvailability(location, content, cancellationToken);
        }
    }
}
