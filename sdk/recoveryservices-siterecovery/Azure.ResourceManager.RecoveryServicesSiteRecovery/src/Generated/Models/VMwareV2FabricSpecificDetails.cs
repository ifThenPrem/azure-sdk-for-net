// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareV2 fabric specific details. </summary>
    public partial class VMwareV2FabricSpecificDetails : FabricSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="VMwareV2FabricSpecificDetails"/>. </summary>
        internal VMwareV2FabricSpecificDetails()
        {
            ProcessServers = new ChangeTrackingList<SiteRecoveryProcessServerDetails>();
            InstanceType = "VMwareV2";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareV2FabricSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmwareSiteId"> The ARM Id of the VMware site. </param>
        /// <param name="physicalSiteId"> The ARM Id of the physical site. </param>
        /// <param name="migrationSolutionId"> The Migration solution ARM Id. </param>
        /// <param name="serviceEndpoint"> The service endpoint. </param>
        /// <param name="serviceResourceId"> The service resource Id. </param>
        /// <param name="serviceContainerId"> The service container Id. </param>
        /// <param name="processServers"> The list of process servers. </param>
        internal VMwareV2FabricSpecificDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier vmwareSiteId, ResourceIdentifier physicalSiteId, ResourceIdentifier migrationSolutionId, string serviceEndpoint, ResourceIdentifier serviceResourceId, string serviceContainerId, IReadOnlyList<SiteRecoveryProcessServerDetails> processServers) : base(instanceType, serializedAdditionalRawData)
        {
            VMwareSiteId = vmwareSiteId;
            PhysicalSiteId = physicalSiteId;
            MigrationSolutionId = migrationSolutionId;
            ServiceEndpoint = serviceEndpoint;
            ServiceResourceId = serviceResourceId;
            ServiceContainerId = serviceContainerId;
            ProcessServers = processServers;
            InstanceType = instanceType ?? "VMwareV2";
        }

        /// <summary> The ARM Id of the VMware site. </summary>
        public ResourceIdentifier VMwareSiteId { get; }
        /// <summary> The ARM Id of the physical site. </summary>
        public ResourceIdentifier PhysicalSiteId { get; }
        /// <summary> The Migration solution ARM Id. </summary>
        public ResourceIdentifier MigrationSolutionId { get; }
        /// <summary> The service endpoint. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> The service resource Id. </summary>
        public ResourceIdentifier ServiceResourceId { get; }
        /// <summary> The service container Id. </summary>
        public string ServiceContainerId { get; }
        /// <summary> The list of process servers. </summary>
        public IReadOnlyList<SiteRecoveryProcessServerDetails> ProcessServers { get; }
    }
}
