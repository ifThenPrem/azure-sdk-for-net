// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Base class for restore request. Workload-specific restore requests are derived from this class. </summary>
    public partial class TriggerRestoreContent : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TriggerRestoreContent"/>. </summary>
        /// <param name="location"> The location. </param>
        public TriggerRestoreContent(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="TriggerRestoreContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// RestoreRequestResource properties
        /// Please note <see cref="RestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileShareRestoreContent"/>, <see cref="WorkloadPointInTimeRestoreContent"/>, <see cref="WorkloadRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/>, <see cref="WorkloadSapHanaRestoreContent"/>, <see cref="WorkloadSapHanaRestoreWithRehydrateContent"/>, <see cref="WorkloadSqlPointInTimeRestoreContent"/>, <see cref="WorkloadSqlPointInTimeRestoreWithRehydrateContent"/>, <see cref="WorkloadSqlRestoreContent"/>, <see cref="WorkloadSqlRestoreWithRehydrateContent"/>, <see cref="IaasVmRestoreContent"/> and <see cref="IaasVmRestoreWithRehydrationContent"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TriggerRestoreContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RestoreContent properties, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TriggerRestoreContent"/> for deserialization. </summary>
        internal TriggerRestoreContent()
        {
        }

        /// <summary>
        /// RestoreRequestResource properties
        /// Please note <see cref="RestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileShareRestoreContent"/>, <see cref="WorkloadPointInTimeRestoreContent"/>, <see cref="WorkloadRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/>, <see cref="WorkloadSapHanaRestoreContent"/>, <see cref="WorkloadSapHanaRestoreWithRehydrateContent"/>, <see cref="WorkloadSqlPointInTimeRestoreContent"/>, <see cref="WorkloadSqlPointInTimeRestoreWithRehydrateContent"/>, <see cref="WorkloadSqlRestoreContent"/>, <see cref="WorkloadSqlRestoreWithRehydrateContent"/>, <see cref="IaasVmRestoreContent"/> and <see cref="IaasVmRestoreWithRehydrationContent"/>.
        /// </summary>
        public RestoreContent Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
