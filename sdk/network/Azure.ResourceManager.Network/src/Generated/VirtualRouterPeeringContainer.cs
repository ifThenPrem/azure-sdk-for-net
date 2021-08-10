// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualRouterPeering and their operations over a VirtualRouter. </summary>
    public partial class VirtualRouterPeeringContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualRouterPeeringContainer"/> class for mocking. </summary>
        protected VirtualRouterPeeringContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualRouterPeeringContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualRouterPeeringContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualRouterPeeringsRestOperations _restClient => new VirtualRouterPeeringsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualRouterOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<VirtualRouterPeering> CreateOrUpdate(string peeringName, VirtualRouterPeeringData parameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(peeringName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<VirtualRouterPeering>> CreateOrUpdateAsync(string peeringName, VirtualRouterPeeringData parameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(peeringName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualRouterPeeringCreateOrUpdateOperation StartCreateOrUpdate(string peeringName, VirtualRouterPeeringData parameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, peeringName, parameters, cancellationToken);
                return new VirtualRouterPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, peeringName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualRouterPeeringCreateOrUpdateOperation> StartCreateOrUpdateAsync(string peeringName, VirtualRouterPeeringData parameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, peeringName, parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualRouterPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, peeringName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualRouterPeering> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.Get");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualRouterPeering>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.Get");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualRouterPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualRouterPeering> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetIfExists");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualRouterPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualRouterPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualRouterPeering>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetIfExists");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualRouterPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualRouterPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = GetIfExists(peeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = await GetIfExistsAsync(peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualRouterPeering" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualRouterPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualRouterPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualRouterPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualRouterPeering" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualRouterPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualRouterPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualRouterPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualRouterPeering" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualRouterPeeringOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualRouterPeering" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualRouterPeeringOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VirtualRouterPeering, VirtualRouterPeeringData> Construct() { }
    }
}
