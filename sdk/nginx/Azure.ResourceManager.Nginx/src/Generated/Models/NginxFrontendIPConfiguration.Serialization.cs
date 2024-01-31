// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxFrontendIPConfiguration : IUtf8JsonSerializable, IJsonModel<NginxFrontendIPConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxFrontendIPConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NginxFrontendIPConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxFrontendIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxFrontendIPConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicIPAddresses))
            {
                writer.WritePropertyName("publicIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPAddresses)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateIPAddresses))
            {
                writer.WritePropertyName("privateIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        NginxFrontendIPConfiguration IJsonModel<NginxFrontendIPConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxFrontendIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxFrontendIPConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxFrontendIPConfiguration(document.RootElement, options);
        }

        internal static NginxFrontendIPConfiguration DeserializeNginxFrontendIPConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WritableSubResource>> publicIPAddresses = default;
            Optional<IList<NginxPrivateIPAddress>> privateIPAddresses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    publicIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("privateIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxPrivateIPAddress> array = new List<NginxPrivateIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxPrivateIPAddress.DeserializeNginxPrivateIPAddress(item));
                    }
                    privateIPAddresses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxFrontendIPConfiguration(Optional.ToList(publicIPAddresses), Optional.ToList(privateIPAddresses), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxFrontendIPConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxFrontendIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxFrontendIPConfiguration)} does not support '{options.Format}' format.");
            }
        }

        NginxFrontendIPConfiguration IPersistableModel<NginxFrontendIPConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxFrontendIPConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxFrontendIPConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxFrontendIPConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxFrontendIPConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
