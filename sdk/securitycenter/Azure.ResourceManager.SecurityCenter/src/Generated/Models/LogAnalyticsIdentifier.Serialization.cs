// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class LogAnalyticsIdentifier : IUtf8JsonSerializable, IJsonModel<LogAnalyticsIdentifier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogAnalyticsIdentifier>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogAnalyticsIdentifier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogAnalyticsIdentifier)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(WorkspaceSubscriptionId))
            {
                writer.WritePropertyName("workspaceSubscriptionId"u8);
                writer.WriteStringValue(WorkspaceSubscriptionId);
            }
            if (options.Format != "W" && Optional.IsDefined(WorkspaceResourceGroup))
            {
                writer.WritePropertyName("workspaceResourceGroup"u8);
                writer.WriteStringValue(WorkspaceResourceGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentId))
            {
                writer.WritePropertyName("agentId"u8);
                writer.WriteStringValue(AgentId.Value);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ResourceIdentifierType.ToString());
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

        LogAnalyticsIdentifier IJsonModel<LogAnalyticsIdentifier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogAnalyticsIdentifier)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogAnalyticsIdentifier(document.RootElement, options);
        }

        internal static LogAnalyticsIdentifier DeserializeLogAnalyticsIdentifier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> workspaceId = default;
            Optional<string> workspaceSubscriptionId = default;
            Optional<string> workspaceResourceGroup = default;
            Optional<Guid> agentId = default;
            ResourceIdentifierType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("workspaceSubscriptionId"u8))
                {
                    workspaceSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceResourceGroup"u8))
                {
                    workspaceResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceIdentifierType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogAnalyticsIdentifier(type, serializedAdditionalRawData, Optional.ToNullable(workspaceId), workspaceSubscriptionId.Value, workspaceResourceGroup.Value, Optional.ToNullable(agentId));
        }

        BinaryData IPersistableModel<LogAnalyticsIdentifier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogAnalyticsIdentifier)} does not support '{options.Format}' format.");
            }
        }

        LogAnalyticsIdentifier IPersistableModel<LogAnalyticsIdentifier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogAnalyticsIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogAnalyticsIdentifier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogAnalyticsIdentifier)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogAnalyticsIdentifier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
