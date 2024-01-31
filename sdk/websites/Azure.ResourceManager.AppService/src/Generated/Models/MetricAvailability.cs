// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Retention policy of a resource metric. </summary>
    public partial class MetricAvailability
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

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        internal MetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetricAvailability"/>. </summary>
        /// <param name="timeGrain"></param>
        /// <param name="blobDuration"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricAvailability(string timeGrain, TimeSpan? blobDuration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeGrain = timeGrain;
            BlobDuration = blobDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the time grain. </summary>
        public string TimeGrain { get; }
        /// <summary> Gets the blob duration. </summary>
        public TimeSpan? BlobDuration { get; }
    }
}
