// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Object of plans per context. </summary>
    public partial class ContextAndPlansDetails
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

        /// <summary> Initializes a new instance of <see cref="ContextAndPlansDetails"/>. </summary>
        public ContextAndPlansDetails()
        {
            PlanIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContextAndPlansDetails"/>. </summary>
        /// <param name="context"> Plan's context, e.g. subscription ID, tenant ID. </param>
        /// <param name="planIds"> List of plan IDs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContextAndPlansDetails(string context, IList<string> planIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Context = context;
            PlanIds = planIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Plan's context, e.g. subscription ID, tenant ID. </summary>
        public string Context { get; set; }
        /// <summary> List of plan IDs. </summary>
        public IList<string> PlanIds { get; }
    }
}
