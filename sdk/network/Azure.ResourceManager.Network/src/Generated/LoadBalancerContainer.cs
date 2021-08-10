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
    /// <summary> A class representing collection of LoadBalancer and their operations over a ResourceGroup. </summary>
    public partial class LoadBalancerContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="LoadBalancerContainer"/> class for mocking. </summary>
        protected LoadBalancerContainer()
        {
        }

        /// <summary> Initializes a new instance of LoadBalancerContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal LoadBalancerContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private LoadBalancersRestOperations _restClient => new LoadBalancersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a load balancer. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<LoadBalancer> CreateOrUpdate(string loadBalancerName, LoadBalancerData parameters, CancellationToken cancellationToken = default)
        {
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(loadBalancerName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> CreateOrUpdateAsync(string loadBalancerName, LoadBalancerData parameters, CancellationToken cancellationToken = default)
        {
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(loadBalancerName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual LoadBalancerCreateOrUpdateOperation StartCreateOrUpdate(string loadBalancerName, LoadBalancerData parameters, CancellationToken cancellationToken = default)
        {
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, loadBalancerName, parameters, cancellationToken);
                return new LoadBalancerCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, loadBalancerName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a load balancer. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<LoadBalancerCreateOrUpdateOperation> StartCreateOrUpdateAsync(string loadBalancerName, LoadBalancerData parameters, CancellationToken cancellationToken = default)
        {
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, loadBalancerName, parameters, cancellationToken).ConfigureAwait(false);
                return new LoadBalancerCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, loadBalancerName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<LoadBalancer> Get(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.Get");
            scope.Start();
            try
            {
                if (loadBalancerName == null)
                {
                    throw new ArgumentNullException(nameof(loadBalancerName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, loadBalancerName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancer(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<LoadBalancer>> GetAsync(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.Get");
            scope.Start();
            try
            {
                if (loadBalancerName == null)
                {
                    throw new ArgumentNullException(nameof(loadBalancerName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, loadBalancerName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<LoadBalancer> GetIfExists(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetIfExists");
            scope.Start();
            try
            {
                if (loadBalancerName == null)
                {
                    throw new ArgumentNullException(nameof(loadBalancerName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, loadBalancerName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<LoadBalancer>(null, response.GetRawResponse())
                    : Response.FromValue(new LoadBalancer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<LoadBalancer>> GetIfExistsAsync(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetIfExists");
            scope.Start();
            try
            {
                if (loadBalancerName == null)
                {
                    throw new ArgumentNullException(nameof(loadBalancerName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, loadBalancerName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<LoadBalancer>(null, response.GetRawResponse())
                    : Response.FromValue(new LoadBalancer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (loadBalancerName == null)
                {
                    throw new ArgumentNullException(nameof(loadBalancerName));
                }

                var response = GetIfExists(loadBalancerName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string loadBalancerName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (loadBalancerName == null)
                {
                    throw new ArgumentNullException(nameof(loadBalancerName));
                }

                var response = await GetIfExistsAsync(loadBalancerName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the load balancers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancer" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<LoadBalancer> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LoadBalancer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LoadBalancer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the load balancers in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancer" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<LoadBalancer> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LoadBalancer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LoadBalancer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LoadBalancer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="LoadBalancer" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LoadBalancerOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="LoadBalancer" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoadBalancerContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(LoadBalancerOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, LoadBalancer, LoadBalancerData> Construct() { }
    }
}
