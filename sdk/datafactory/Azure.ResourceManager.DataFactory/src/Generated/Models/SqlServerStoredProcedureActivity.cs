// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SQL stored procedure activity type. </summary>
    public partial class SqlServerStoredProcedureActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="SqlServerStoredProcedureActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="storedProcedureName"> Stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="storedProcedureName"/> is null. </exception>
        public SqlServerStoredProcedureActivity(string name, DataFactoryElement<string> storedProcedureName) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(storedProcedureName, nameof(storedProcedureName));

            StoredProcedureName = storedProcedureName;
            ActivityType = "SqlServerStoredProcedure";
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerStoredProcedureActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storedProcedureName"> Stored procedure name. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}". </param>
        internal SqlServerStoredProcedureActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, Core.Expressions.DataFactory.DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> storedProcedureName, BinaryData storedProcedureParameters) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StoredProcedureName = storedProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            ActivityType = activityType ?? "SqlServerStoredProcedure";
        }

        /// <summary> Stored procedure name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> StoredProcedureName { get; set; }
        /// <summary>
        /// Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}".
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData StoredProcedureParameters { get; set; }
    }
}
