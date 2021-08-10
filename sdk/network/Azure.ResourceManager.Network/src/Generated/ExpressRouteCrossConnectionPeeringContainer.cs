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
    /// <summary> A class representing collection of ExpressRouteCrossConnectionPeering and their operations over a ExpressRouteCrossConnection. </summary>
    public partial class ExpressRouteCrossConnectionPeeringContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringContainer"/> class for mocking. </summary>
        protected ExpressRouteCrossConnectionPeeringContainer()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionPeeringContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteCrossConnectionPeeringContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ExpressRouteCrossConnectionPeeringsRestOperations _restClient => new ExpressRouteCrossConnectionPeeringsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ExpressRouteCrossConnectionOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a peering in the specified ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnectionPeering> CreateOrUpdate(string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(peeringName, peeringParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a peering in the specified ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> CreateOrUpdateAsync(string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(peeringName, peeringParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a peering in the specified ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public virtual ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation StartCreateOrUpdate(string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken);
                return new ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a peering in the specified ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation> StartCreateOrUpdateAsync(string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ExpressRouteCrossConnectionPeering> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.Get");
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
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.Get");
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
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ExpressRouteCrossConnectionPeering> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetIfExists");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCrossConnectionPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCrossConnectionPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetIfExists");
            scope.Start();
            try
            {
                if (peeringName == null)
                {
                    throw new ArgumentNullException(nameof(peeringName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCrossConnectionPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCrossConnectionPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.CheckIfExists");
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
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.CheckIfExists");
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

        /// <summary> Gets all peerings in a specified ExpressRouteCrossConnection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCrossConnectionPeering" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ExpressRouteCrossConnectionPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCrossConnectionPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCrossConnectionPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all peerings in a specified ExpressRouteCrossConnection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCrossConnectionPeering" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ExpressRouteCrossConnectionPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCrossConnectionPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCrossConnectionPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ExpressRouteCrossConnectionPeering" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteCrossConnectionPeeringOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExpressRouteCrossConnectionPeering" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteCrossConnectionPeeringOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, ExpressRouteCrossConnectionPeering, ExpressRouteCrossConnectionPeeringData> Construct() { }
    }
}
