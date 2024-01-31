// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A SQL Analytics pool patch info. </summary>
    public partial class SynapseSqlPoolPatch
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

        /// <summary> Initializes a new instance of <see cref="SynapseSqlPoolPatch"/>. </summary>
        public SynapseSqlPoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSqlPoolPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="sku"> SQL pool SKU. </param>
        /// <param name="maxSizeBytes"> Maximum size in bytes. </param>
        /// <param name="collation"> Collation mode. </param>
        /// <param name="sourceDatabaseId"> Source database to create from. </param>
        /// <param name="recoverableDatabaseId"> Backup database to restore from. </param>
        /// <param name="provisioningState"> Resource state. </param>
        /// <param name="status"> Resource status. </param>
        /// <param name="restorePointInTime"> Snapshot time to restore. </param>
        /// <param name="createMode">
        /// Specifies the mode of sql pool creation.
        ///
        /// Default: regular sql pool creation.
        ///
        /// PointInTimeRestore: Creates a sql pool by restoring a point in time backup of an existing sql pool. sourceDatabaseId must be specified as the resource ID of the existing sql pool, and restorePointInTime must be specified.
        ///
        /// Recovery: Creates a sql pool by a geo-replicated backup. sourceDatabaseId  must be specified as the recoverableDatabaseId to restore.
        ///
        /// Restore: Creates a sql pool by restoring a backup of a deleted sql  pool. SourceDatabaseId should be the sql pool's original resource ID. SourceDatabaseId and sourceDatabaseDeletionDate must be specified.
        /// </param>
        /// <param name="createdOn"> Date the SQL pool was created. </param>
        /// <param name="storageAccountType"> The storage account type used to store backups for this sql pool. </param>
        /// <param name="sourceDatabaseDeletionOn"> Specifies the time that the sql pool was deleted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseSqlPoolPatch(IDictionary<string, string> tags, AzureLocation? location, SynapseSku sku, long? maxSizeBytes, string collation, string sourceDatabaseId, string recoverableDatabaseId, string provisioningState, string status, DateTimeOffset? restorePointInTime, SqlPoolCreateMode? createMode, DateTimeOffset? createdOn, SqlPoolStorageAccountType? storageAccountType, DateTimeOffset? sourceDatabaseDeletionOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Location = location;
            Sku = sku;
            MaxSizeBytes = maxSizeBytes;
            Collation = collation;
            SourceDatabaseId = sourceDatabaseId;
            RecoverableDatabaseId = recoverableDatabaseId;
            ProvisioningState = provisioningState;
            Status = status;
            RestorePointInTime = restorePointInTime;
            CreateMode = createMode;
            CreatedOn = createdOn;
            StorageAccountType = storageAccountType;
            SourceDatabaseDeletionOn = sourceDatabaseDeletionOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> SQL pool SKU. </summary>
        public SynapseSku Sku { get; set; }
        /// <summary> Maximum size in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> Collation mode. </summary>
        public string Collation { get; set; }
        /// <summary> Source database to create from. </summary>
        public string SourceDatabaseId { get; set; }
        /// <summary> Backup database to restore from. </summary>
        public string RecoverableDatabaseId { get; set; }
        /// <summary> Resource state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> Resource status. </summary>
        public string Status { get; }
        /// <summary> Snapshot time to restore. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary>
        /// Specifies the mode of sql pool creation.
        ///
        /// Default: regular sql pool creation.
        ///
        /// PointInTimeRestore: Creates a sql pool by restoring a point in time backup of an existing sql pool. sourceDatabaseId must be specified as the resource ID of the existing sql pool, and restorePointInTime must be specified.
        ///
        /// Recovery: Creates a sql pool by a geo-replicated backup. sourceDatabaseId  must be specified as the recoverableDatabaseId to restore.
        ///
        /// Restore: Creates a sql pool by restoring a backup of a deleted sql  pool. SourceDatabaseId should be the sql pool's original resource ID. SourceDatabaseId and sourceDatabaseDeletionDate must be specified.
        /// </summary>
        public SqlPoolCreateMode? CreateMode { get; set; }
        /// <summary> Date the SQL pool was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The storage account type used to store backups for this sql pool. </summary>
        public SqlPoolStorageAccountType? StorageAccountType { get; set; }
        /// <summary> Specifies the time that the sql pool was deleted. </summary>
        public DateTimeOffset? SourceDatabaseDeletionOn { get; set; }
    }
}
