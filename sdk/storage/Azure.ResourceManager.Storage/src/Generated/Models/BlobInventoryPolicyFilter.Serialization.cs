// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobInventoryPolicyFilter : IUtf8JsonSerializable, IJsonModel<BlobInventoryPolicyFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobInventoryPolicyFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BlobInventoryPolicyFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyFilter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IncludePrefix))
            {
                writer.WritePropertyName("prefixMatch"u8);
                writer.WriteStartArray();
                foreach (var item in IncludePrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludePrefix))
            {
                writer.WritePropertyName("excludePrefix"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludePrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BlobTypes))
            {
                writer.WritePropertyName("blobTypes"u8);
                writer.WriteStartArray();
                foreach (var item in BlobTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IncludeBlobVersions))
            {
                writer.WritePropertyName("includeBlobVersions"u8);
                writer.WriteBooleanValue(IncludeBlobVersions.Value);
            }
            if (Optional.IsDefined(IncludeSnapshots))
            {
                writer.WritePropertyName("includeSnapshots"u8);
                writer.WriteBooleanValue(IncludeSnapshots.Value);
            }
            if (Optional.IsDefined(IncludeDeleted))
            {
                writer.WritePropertyName("includeDeleted"u8);
                writer.WriteBooleanValue(IncludeDeleted.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BlobInventoryPolicyFilter IJsonModel<BlobInventoryPolicyFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyFilter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobInventoryPolicyFilter(document.RootElement, options);
        }

        internal static BlobInventoryPolicyFilter DeserializeBlobInventoryPolicyFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> prefixMatch = default;
            Optional<IList<string>> excludePrefix = default;
            Optional<IList<string>> blobTypes = default;
            Optional<bool> includeBlobVersions = default;
            Optional<bool> includeSnapshots = default;
            Optional<bool> includeDeleted = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefixMatch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    prefixMatch = array;
                    continue;
                }
                if (property.NameEquals("excludePrefix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludePrefix = array;
                    continue;
                }
                if (property.NameEquals("blobTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    blobTypes = array;
                    continue;
                }
                if (property.NameEquals("includeBlobVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeBlobVersions = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeSnapshots"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeSnapshots = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includeDeleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeDeleted = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlobInventoryPolicyFilter(Optional.ToList(prefixMatch), Optional.ToList(excludePrefix), Optional.ToList(blobTypes), Optional.ToNullable(includeBlobVersions), Optional.ToNullable(includeSnapshots), Optional.ToNullable(includeDeleted), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobInventoryPolicyFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BlobInventoryPolicyFilter)} does not support '{options.Format}' format.");
            }
        }

        BlobInventoryPolicyFilter IPersistableModel<BlobInventoryPolicyFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlobInventoryPolicyFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobInventoryPolicyFilter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobInventoryPolicyFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
