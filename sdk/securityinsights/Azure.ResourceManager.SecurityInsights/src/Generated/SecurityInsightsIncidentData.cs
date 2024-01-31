// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsIncident data model.
    /// Represents an incident in Azure Security Insights.
    /// </summary>
    public partial class SecurityInsightsIncidentData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentData"/>. </summary>
        public SecurityInsightsIncidentData()
        {
            Labels = new ChangeTrackingList<SecurityInsightsIncidentLabel>();
            RelatedAnalyticRuleIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="additionalInfo"> Additional data on the incident. </param>
        /// <param name="classification"> The reason the incident was closed. </param>
        /// <param name="classificationComment"> Describes the reason the incident was closed. </param>
        /// <param name="classificationReason"> The classification reason the incident was closed with. </param>
        /// <param name="createdOn"> The time the incident was created. </param>
        /// <param name="description"> The description of the incident. </param>
        /// <param name="firstActivityOn"> The time of the first activity in the incident. </param>
        /// <param name="incidentUri"> The deep-link url to the incident in Azure portal. </param>
        /// <param name="incidentNumber"> A sequential number. </param>
        /// <param name="labels"> List of labels relevant to this incident. </param>
        /// <param name="lastActivityOn"> The time of the last activity in the incident. </param>
        /// <param name="lastModifiedOn"> The last time the incident was updated. </param>
        /// <param name="owner"> Describes a user that the incident is assigned to. </param>
        /// <param name="relatedAnalyticRuleIds"> List of resource ids of Analytic rules related to the incident. </param>
        /// <param name="severity"> The severity of the incident. </param>
        /// <param name="status"> The status of the incident. </param>
        /// <param name="title"> The title of the incident. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsIncidentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsIncidentAdditionalInfo additionalInfo, SecurityInsightsIncidentClassification? classification, string classificationComment, SecurityInsightsIncidentClassificationReason? classificationReason, DateTimeOffset? createdOn, string description, DateTimeOffset? firstActivityOn, Uri incidentUri, int? incidentNumber, IList<SecurityInsightsIncidentLabel> labels, DateTimeOffset? lastActivityOn, DateTimeOffset? lastModifiedOn, SecurityInsightsIncidentOwnerInfo owner, IReadOnlyList<ResourceIdentifier> relatedAnalyticRuleIds, SecurityInsightsIncidentSeverity? severity, SecurityInsightsIncidentStatus? status, string title, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AdditionalInfo = additionalInfo;
            Classification = classification;
            ClassificationComment = classificationComment;
            ClassificationReason = classificationReason;
            CreatedOn = createdOn;
            Description = description;
            FirstActivityOn = firstActivityOn;
            IncidentUri = incidentUri;
            IncidentNumber = incidentNumber;
            Labels = labels;
            LastActivityOn = lastActivityOn;
            LastModifiedOn = lastModifiedOn;
            Owner = owner;
            RelatedAnalyticRuleIds = relatedAnalyticRuleIds;
            Severity = severity;
            Status = status;
            Title = title;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Additional data on the incident. </summary>
        public SecurityInsightsIncidentAdditionalInfo AdditionalInfo { get; }
        /// <summary> The reason the incident was closed. </summary>
        public SecurityInsightsIncidentClassification? Classification { get; set; }
        /// <summary> Describes the reason the incident was closed. </summary>
        public string ClassificationComment { get; set; }
        /// <summary> The classification reason the incident was closed with. </summary>
        public SecurityInsightsIncidentClassificationReason? ClassificationReason { get; set; }
        /// <summary> The time the incident was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The description of the incident. </summary>
        public string Description { get; set; }
        /// <summary> The time of the first activity in the incident. </summary>
        public DateTimeOffset? FirstActivityOn { get; set; }
        /// <summary> The deep-link url to the incident in Azure portal. </summary>
        public Uri IncidentUri { get; }
        /// <summary> A sequential number. </summary>
        public int? IncidentNumber { get; }
        /// <summary> List of labels relevant to this incident. </summary>
        public IList<SecurityInsightsIncidentLabel> Labels { get; }
        /// <summary> The time of the last activity in the incident. </summary>
        public DateTimeOffset? LastActivityOn { get; set; }
        /// <summary> The last time the incident was updated. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Describes a user that the incident is assigned to. </summary>
        public SecurityInsightsIncidentOwnerInfo Owner { get; set; }
        /// <summary> List of resource ids of Analytic rules related to the incident. </summary>
        public IReadOnlyList<ResourceIdentifier> RelatedAnalyticRuleIds { get; }
        /// <summary> The severity of the incident. </summary>
        public SecurityInsightsIncidentSeverity? Severity { get; set; }
        /// <summary> The status of the incident. </summary>
        public SecurityInsightsIncidentStatus? Status { get; set; }
        /// <summary> The title of the incident. </summary>
        public string Title { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
