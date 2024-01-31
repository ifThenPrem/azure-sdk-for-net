// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A stream analytics input. </summary>
    public partial class StreamAnalyticsTestContent
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

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="input"> The stream analytics input to test. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public StreamAnalyticsTestContent(StreamingJobInputData input)
        {
            Argument.AssertNotNull(input, nameof(input));

            Input = input;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="input"> The stream analytics input to test. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsTestContent(StreamingJobInputData input, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/> for deserialization. </summary>
        internal StreamAnalyticsTestContent()
        {
        }

        /// <summary> The stream analytics input to test. </summary>
        public StreamingJobInputData Input { get; }
    }
}
