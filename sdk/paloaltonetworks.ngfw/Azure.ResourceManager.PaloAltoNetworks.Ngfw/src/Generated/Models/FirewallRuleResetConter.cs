// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Rule counter reset. </summary>
    public partial class FirewallRuleResetConter
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

        /// <summary> Initializes a new instance of <see cref="FirewallRuleResetConter"/>. </summary>
        internal FirewallRuleResetConter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirewallRuleResetConter"/>. </summary>
        /// <param name="priority"> priority number. </param>
        /// <param name="ruleStackName"> rule Stack Name. </param>
        /// <param name="ruleListName"> rule list name. </param>
        /// <param name="firewallName"> firewall name. </param>
        /// <param name="ruleName"> rule name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallRuleResetConter(string priority, string ruleStackName, string ruleListName, string firewallName, string ruleName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Priority = priority;
            RuleStackName = ruleStackName;
            RuleListName = ruleListName;
            FirewallName = firewallName;
            RuleName = ruleName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> priority number. </summary>
        public string Priority { get; }
        /// <summary> rule Stack Name. </summary>
        public string RuleStackName { get; }
        /// <summary> rule list name. </summary>
        public string RuleListName { get; }
        /// <summary> firewall name. </summary>
        public string FirewallName { get; }
        /// <summary> rule name. </summary>
        public string RuleName { get; }
    }
}
