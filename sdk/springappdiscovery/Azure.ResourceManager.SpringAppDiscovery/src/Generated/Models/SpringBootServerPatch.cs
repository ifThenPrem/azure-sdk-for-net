// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary>
    /// The springbootservers resource patch definition.
    /// Serialized Name: SpringbootserversPatch
    /// </summary>
    public partial class SpringBootServerPatch : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SpringBootServerPatch"/>. </summary>
        public SpringBootServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SpringBootServerPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags">
        /// Resource tags
        /// Serialized Name: SpringbootserversPatch.tags
        /// </param>
        /// <param name="properties">
        /// The springbootsites resource definition.
        /// Serialized Name: SpringbootserversPatch.properties
        /// </param>
        internal SpringBootServerPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, SpringBootServerProperties properties) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// Resource tags
        /// Serialized Name: SpringbootserversPatch.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// The springbootsites resource definition.
        /// Serialized Name: SpringbootserversPatch.properties
        /// </summary>
        public SpringBootServerProperties Properties { get; set; }
    }
}
