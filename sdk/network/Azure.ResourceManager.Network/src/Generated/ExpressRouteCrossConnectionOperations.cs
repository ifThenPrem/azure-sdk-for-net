// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific ExpressRouteCrossConnection. </summary>
    public partial class ExpressRouteCrossConnectionOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ExpressRouteCrossConnectionsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionOperations"/> class for mocking. </summary>
        protected ExpressRouteCrossConnectionOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ExpressRouteCrossConnectionOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ExpressRouteCrossConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCrossConnections";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets details about the specified ExpressRouteCrossConnection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCrossConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCrossConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details about the specified ExpressRouteCrossConnection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCrossConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }
        /// <summary> Updates an express route cross connection tags. </summary>
        /// <param name="crossConnectionParameters"> Parameters supplied to update express route cross connection tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="crossConnectionParameters"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCrossConnection>> UpdateTagsAsync(TagsObject crossConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (crossConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, crossConnectionParameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCrossConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an express route cross connection tags. </summary>
        /// <param name="crossConnectionParameters"> Parameters supplied to update express route cross connection tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="crossConnectionParameters"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnection> UpdateTags(TagsObject crossConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (crossConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(crossConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, crossConnectionParameters, cancellationToken);
                return Response.FromValue(new ExpressRouteCrossConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuitsArpTableListResult>> GetArpTableAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.GetArpTable");
            scope.Start();
            try
            {
                var operation = await StartGetArpTableAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitsArpTableListResult> GetArpTable(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.GetArpTable");
            scope.Start();
            try
            {
                var operation = StartGetArpTable(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteCrossConnectionGetArpTableOperation> StartGetArpTableAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.StartGetArpTable");
            scope.Start();
            try
            {
                var response = await _restClient.GetArpTableAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionGetArpTableOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetArpTableRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionGetArpTableOperation StartGetArpTable(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.StartGetArpTable");
            scope.Start();
            try
            {
                var response = _restClient.GetArpTable(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return new ExpressRouteCrossConnectionGetArpTableOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetArpTableRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>> GetRoutesTableSummaryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.GetRoutesTableSummary");
            scope.Start();
            try
            {
                var operation = await StartGetRoutesTableSummaryAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCrossConnectionsRoutesTableSummaryListResult> GetRoutesTableSummary(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.GetRoutesTableSummary");
            scope.Start();
            try
            {
                var operation = StartGetRoutesTableSummary(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteCrossConnectionGetRoutesTableSummaryOperation> StartGetRoutesTableSummaryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.StartGetRoutesTableSummary");
            scope.Start();
            try
            {
                var response = await _restClient.GetRoutesTableSummaryAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionGetRoutesTableSummaryOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetRoutesTableSummaryRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionGetRoutesTableSummaryOperation StartGetRoutesTableSummary(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.StartGetRoutesTableSummary");
            scope.Start();
            try
            {
                var response = _restClient.GetRoutesTableSummary(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return new ExpressRouteCrossConnectionGetRoutesTableSummaryOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetRoutesTableSummaryRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised routes table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuitsRoutesTableListResult>> GetRoutesTableAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.GetRoutesTable");
            scope.Start();
            try
            {
                var operation = await StartGetRoutesTableAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised routes table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitsRoutesTableListResult> GetRoutesTable(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.GetRoutesTable");
            scope.Start();
            try
            {
                var operation = StartGetRoutesTable(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised routes table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteCrossConnectionGetRoutesTableOperation> StartGetRoutesTableAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.StartGetRoutesTable");
            scope.Start();
            try
            {
                var response = await _restClient.GetRoutesTableAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCrossConnectionGetRoutesTableOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetRoutesTableRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the currently advertised routes table associated with the express route cross connection in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCrossConnectionGetRoutesTableOperation StartGetRoutesTable(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionOperations.StartGetRoutesTable");
            scope.Start();
            try
            {
                var response = _restClient.GetRoutesTable(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return new ExpressRouteCrossConnectionGetRoutesTableOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetRoutesTableRequest(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of ExpressRouteCrossConnectionPeerings in the ExpressRouteCrossConnection. </summary>
        /// <returns> An object representing collection of ExpressRouteCrossConnectionPeerings and their operations over a ExpressRouteCrossConnection. </returns>
        public ExpressRouteCrossConnectionPeeringContainer GetExpressRouteCrossConnectionPeerings()
        {
            return new ExpressRouteCrossConnectionPeeringContainer(this);
        }
    }
}
