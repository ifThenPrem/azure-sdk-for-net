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
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DeviceUpdate. </summary>
    public static partial class DeviceUpdateExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResponse>> CheckDeviceUpdateNameAvailabilityAsync(this Subscription subscription, CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            return await GetExtensionClient(subscription).CheckDeviceUpdateNameAvailabilityAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public static Response<CheckNameAvailabilityResponse> CheckDeviceUpdateNameAvailability(this Subscription subscription, CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            return GetExtensionClient(subscription).CheckDeviceUpdateNameAvailability(request, cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateAccount" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeviceUpdateAccount> GetDeviceUpdateAccountsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeviceUpdateAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateAccount" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeviceUpdateAccount> GetDeviceUpdateAccounts(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeviceUpdateAccounts(cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeviceUpdateAccounts in the DeviceUpdateAccount. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeviceUpdateAccounts and their operations over a DeviceUpdateAccount. </returns>
        public static DeviceUpdateAccountCollection GetDeviceUpdateAccounts(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDeviceUpdateAccounts();
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static async Task<Response<DeviceUpdateAccount>> GetDeviceUpdateAccountAsync(this ResourceGroup resourceGroup, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetDeviceUpdateAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static Response<DeviceUpdateAccount> GetDeviceUpdateAccount(this ResourceGroup resourceGroup, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetDeviceUpdateAccounts().Get(accountName, cancellationToken);
        }

        #region DeviceUpdateAccount
        /// <summary> Gets an object representing a DeviceUpdateAccount along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdateAccount" /> object. </returns>
        public static DeviceUpdateAccount GetDeviceUpdateAccount(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeviceUpdateAccount.ValidateResourceId(id);
                return new DeviceUpdateAccount(client, id);
            }
            );
        }
        #endregion

        #region DeviceUpdateInstance
        /// <summary> Gets an object representing a DeviceUpdateInstance along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeviceUpdateInstance" /> object. </returns>
        public static DeviceUpdateInstance GetDeviceUpdateInstance(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeviceUpdateInstance.ValidateResourceId(id);
                return new DeviceUpdateInstance(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnection.ValidateResourceId(id);
                return new PrivateEndpointConnection(client, id);
            }
            );
        }
        #endregion

        #region PrivateLink
        /// <summary> Gets an object representing a PrivateLink along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLink" /> object. </returns>
        public static PrivateLink GetPrivateLink(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateLink.ValidateResourceId(id);
                return new PrivateLink(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnectionProxy
        /// <summary> Gets an object representing a PrivateEndpointConnectionProxy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnectionProxy" /> object. </returns>
        public static PrivateEndpointConnectionProxy GetPrivateEndpointConnectionProxy(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnectionProxy.ValidateResourceId(id);
                return new PrivateEndpointConnectionProxy(client, id);
            }
            );
        }
        #endregion
    }
}
