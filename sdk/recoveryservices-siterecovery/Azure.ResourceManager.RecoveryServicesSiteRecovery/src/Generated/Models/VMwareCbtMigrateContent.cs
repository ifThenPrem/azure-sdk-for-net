// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific migrate input. </summary>
    public partial class VMwareCbtMigrateContent : MigrateProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtMigrateContent"/>. </summary>
        /// <param name="performShutdown"> A value indicating whether VM is to be shutdown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="performShutdown"/> is null. </exception>
        public VMwareCbtMigrateContent(string performShutdown)
        {
            Argument.AssertNotNull(performShutdown, nameof(performShutdown));

            PerformShutdown = performShutdown;
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtMigrateContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="performShutdown"> A value indicating whether VM is to be shutdown. </param>
        /// <param name="osUpgradeVersion"> A value indicating the inplace OS Upgrade version. </param>
        internal VMwareCbtMigrateContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string performShutdown, string osUpgradeVersion) : base(instanceType, serializedAdditionalRawData)
        {
            PerformShutdown = performShutdown;
            OSUpgradeVersion = osUpgradeVersion;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtMigrateContent"/> for deserialization. </summary>
        internal VMwareCbtMigrateContent()
        {
        }

        /// <summary> A value indicating whether VM is to be shutdown. </summary>
        public string PerformShutdown { get; }
        /// <summary> A value indicating the inplace OS Upgrade version. </summary>
        public string OSUpgradeVersion { get; set; }
    }
}
