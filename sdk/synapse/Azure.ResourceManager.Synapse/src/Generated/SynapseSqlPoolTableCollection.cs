// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseSqlPoolTableResource"/> and their operations.
    /// Each <see cref="SynapseSqlPoolTableResource"/> in the collection will belong to the same instance of <see cref="SynapseSqlPoolSchemaResource"/>.
    /// To get a <see cref="SynapseSqlPoolTableCollection"/> instance call the GetSynapseSqlPoolTables method from an instance of <see cref="SynapseSqlPoolSchemaResource"/>.
    /// </summary>
    public partial class SynapseSqlPoolTableCollection : ArmCollection, IEnumerable<SynapseSqlPoolTableResource>, IAsyncEnumerable<SynapseSqlPoolTableResource>
    {
        private readonly ClientDiagnostics _synapseSqlPoolTableSqlPoolTablesClientDiagnostics;
        private readonly SqlPoolTablesRestOperations _synapseSqlPoolTableSqlPoolTablesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolTableCollection"/> class for mocking. </summary>
        protected SynapseSqlPoolTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSqlPoolTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSqlPoolTableSqlPoolTablesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSqlPoolTableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSqlPoolTableResource.ResourceType, out string synapseSqlPoolTableSqlPoolTablesApiVersion);
            _synapseSqlPoolTableSqlPoolTablesRestClient = new SqlPoolTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSqlPoolTableSqlPoolTablesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolSchemaResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolSchemaResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Sql pool table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<SynapseSqlPoolTableResource>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _synapseSqlPoolTableSqlPoolTablesClientDiagnostics.CreateScope("SynapseSqlPoolTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolTableSqlPoolTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sql pool table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<SynapseSqlPoolTableResource> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _synapseSqlPoolTableSqlPoolTablesClientDiagnostics.CreateScope("SynapseSqlPoolTableCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolTableSqlPoolTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets tables of a given schema in a SQL pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_ListBySchema</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseSqlPoolTableResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseSqlPoolTableResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolTableSqlPoolTablesRestClient.CreateListBySchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolTableSqlPoolTablesRestClient.CreateListBySchemaNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseSqlPoolTableResource(Client, SynapseSqlPoolTableData.DeserializeSynapseSqlPoolTableData(e)), _synapseSqlPoolTableSqlPoolTablesClientDiagnostics, Pipeline, "SynapseSqlPoolTableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets tables of a given schema in a SQL pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_ListBySchema</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseSqlPoolTableResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseSqlPoolTableResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolTableSqlPoolTablesRestClient.CreateListBySchemaRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolTableSqlPoolTablesRestClient.CreateListBySchemaNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseSqlPoolTableResource(Client, SynapseSqlPoolTableData.DeserializeSynapseSqlPoolTableData(e)), _synapseSqlPoolTableSqlPoolTablesClientDiagnostics, Pipeline, "SynapseSqlPoolTableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _synapseSqlPoolTableSqlPoolTablesClientDiagnostics.CreateScope("SynapseSqlPoolTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolTableSqlPoolTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _synapseSqlPoolTableSqlPoolTablesClientDiagnostics.CreateScope("SynapseSqlPoolTableCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolTableSqlPoolTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<NullableResponse<SynapseSqlPoolTableResource>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _synapseSqlPoolTableSqlPoolTablesClientDiagnostics.CreateScope("SynapseSqlPoolTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolTableSqlPoolTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSqlPoolTableResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseSqlPoolTableResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual NullableResponse<SynapseSqlPoolTableResource> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _synapseSqlPoolTableSqlPoolTablesClientDiagnostics.CreateScope("SynapseSqlPoolTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolTableSqlPoolTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSqlPoolTableResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseSqlPoolTableResource> IEnumerable<SynapseSqlPoolTableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseSqlPoolTableResource> IAsyncEnumerable<SynapseSqlPoolTableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
