// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class LexicalNormalizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static LexicalNormalizer DeserializeLexicalNormalizer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.CustomNormalizer": return CustomNormalizer.DeserializeCustomNormalizer(element);
                }
            }
            return UnknownLexicalNormalizer.DeserializeUnknownLexicalNormalizer(element);
        }
    }
}
