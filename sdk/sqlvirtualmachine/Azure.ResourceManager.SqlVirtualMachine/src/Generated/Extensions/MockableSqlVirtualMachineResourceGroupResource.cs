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
using Azure.ResourceManager.SqlVirtualMachine;

namespace Azure.ResourceManager.SqlVirtualMachine.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableSqlVirtualMachineResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableSqlVirtualMachineResourceGroupResource"/> class for mocking. </summary>
        protected MockableSqlVirtualMachineResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSqlVirtualMachineResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSqlVirtualMachineResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SqlVmGroupResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SqlVmGroupResources and their operations over a SqlVmGroupResource. </returns>
        public virtual SqlVmGroupCollection GetSqlVmGroups()
        {
            return GetCachedClient(client => new SqlVmGroupCollection(client, Id));
        }

        /// <summary>
        /// Gets a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlVmGroupResource>> GetSqlVmGroupAsync(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            return await GetSqlVmGroups().GetAsync(sqlVmGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a SQL virtual machine group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/{sqlVirtualMachineGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachineGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmGroupName"> Name of the SQL virtual machine group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlVmGroupResource> GetSqlVmGroup(string sqlVmGroupName, CancellationToken cancellationToken = default)
        {
            return GetSqlVmGroups().Get(sqlVmGroupName, cancellationToken);
        }

        /// <summary> Gets a collection of SqlVmResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SqlVmResources and their operations over a SqlVmResource. </returns>
        public virtual SqlVmCollection GetSqlVms()
        {
            return GetCachedClient(client => new SqlVmCollection(client, Id));
        }

        /// <summary>
        /// Gets a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SqlVmResource>> GetSqlVmAsync(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetSqlVms().GetAsync(sqlVmName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a SQL virtual machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlVmResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVmName"> Name of the SQL virtual machine. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVmName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sqlVmName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SqlVmResource> GetSqlVm(string sqlVmName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetSqlVms().Get(sqlVmName, expand, cancellationToken);
        }
    }
}
