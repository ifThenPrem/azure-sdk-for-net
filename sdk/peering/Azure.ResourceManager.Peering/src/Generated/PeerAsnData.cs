// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing the PeerAsn data model.
    /// The essential information related to the peer's ASN.
    /// </summary>
    public partial class PeerAsnData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PeerAsnData"/>. </summary>
        public PeerAsnData()
        {
            PeerContactDetail = new ChangeTrackingList<PeerAsnContactDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="PeerAsnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="peerAsn"> The Autonomous System Number (ASN) of the peer. </param>
        /// <param name="peerContactDetail"> The contact details of the peer. </param>
        /// <param name="peerName"> The name of the peer. </param>
        /// <param name="validationState"> The validation state of the ASN associated with the peer. </param>
        /// <param name="errorMessage"> The error message for the validation state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeerAsnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? peerAsn, IList<PeerAsnContactDetail> peerContactDetail, string peerName, PeerAsnValidationState? validationState, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PeerAsn = peerAsn;
            PeerContactDetail = peerContactDetail;
            PeerName = peerName;
            ValidationState = validationState;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Autonomous System Number (ASN) of the peer. </summary>
        public int? PeerAsn { get; set; }
        /// <summary> The contact details of the peer. </summary>
        public IList<PeerAsnContactDetail> PeerContactDetail { get; }
        /// <summary> The name of the peer. </summary>
        public string PeerName { get; set; }
        /// <summary> The validation state of the ASN associated with the peer. </summary>
        public PeerAsnValidationState? ValidationState { get; }
        /// <summary> The error message for the validation state. </summary>
        public string ErrorMessage { get; }
    }
}
