// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Event details for VMwareCbt provider. </summary>
    public partial class VMwareCbtEventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtEventDetails"/>. </summary>
        internal VMwareCbtEventDetails()
        {
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtEventDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="migrationItemName"> The migration item name. </param>
        internal VMwareCbtEventDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string migrationItemName) : base(instanceType, serializedAdditionalRawData)
        {
            MigrationItemName = migrationItemName;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> The migration item name. </summary>
        public string MigrationItemName { get; }
    }
}
