// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary>
    /// A word object consisting of a contiguous sequence of characters.  For non-space
    /// delimited languages, such as Chinese, Japanese, and Korean, each character is
    /// represented as its own word.
    /// </summary>
    public partial class DocumentWord
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

        /// <summary> Initializes a new instance of <see cref="DocumentWord"/>. </summary>
        /// <param name="content"> Text content of the word. </param>
        /// <param name="span"> Location of the word in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the word. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="span"/> is null. </exception>
        internal DocumentWord(string content, DocumentSpan span, float confidence)
        {
            Argument.AssertNotNull(content, nameof(content));
            Argument.AssertNotNull(span, nameof(span));

            Content = content;
            Polygon = new ChangeTrackingList<float>();
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentWord"/>. </summary>
        /// <param name="content"> Text content of the word. </param>
        /// <param name="polygon">
        /// Bounding polygon of the word, with coordinates specified relative to the
        /// top-left of the page. The numbers represent the x, y values of the polygon
        /// vertices, clockwise from the left (-180 degrees inclusive) relative to the
        /// element orientation.
        /// </param>
        /// <param name="span"> Location of the word in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the word. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentWord(string content, IReadOnlyList<float> polygon, DocumentSpan span, float confidence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            Polygon = polygon;
            Span = span;
            Confidence = confidence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentWord"/> for deserialization. </summary>
        internal DocumentWord()
        {
        }

        /// <summary> Text content of the word. </summary>
        public string Content { get; }
        /// <summary>
        /// Bounding polygon of the word, with coordinates specified relative to the
        /// top-left of the page. The numbers represent the x, y values of the polygon
        /// vertices, clockwise from the left (-180 degrees inclusive) relative to the
        /// element orientation.
        /// </summary>
        public IReadOnlyList<float> Polygon { get; }
        /// <summary> Location of the word in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> Confidence of correctly extracting the word. </summary>
        public float Confidence { get; }
    }
}
