// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<RedisCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RedisConfiguration))
            {
                writer.WritePropertyName("redisConfiguration"u8);
                writer.WriteObjectValue(RedisConfiguration);
            }
            if (Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion"u8);
                writer.WriteStringValue(RedisVersion);
            }
            if (Optional.IsDefined(EnableNonSslPort))
            {
                writer.WritePropertyName("enableNonSslPort"u8);
                writer.WriteBooleanValue(EnableNonSslPort.Value);
            }
            if (Optional.IsDefined(ReplicasPerMaster))
            {
                writer.WritePropertyName("replicasPerMaster"u8);
                writer.WriteNumberValue(ReplicasPerMaster.Value);
            }
            if (Optional.IsDefined(ReplicasPerPrimary))
            {
                writer.WritePropertyName("replicasPerPrimary"u8);
                writer.WriteNumberValue(ReplicasPerPrimary.Value);
            }
            if (Optional.IsCollectionDefined(TenantSettings))
            {
                writer.WritePropertyName("tenantSettings"u8);
                writer.WriteStartObject();
                foreach (var item in TenantSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ShardCount))
            {
                writer.WritePropertyName("shardCount"u8);
                writer.WriteNumberValue(ShardCount.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(UpdateChannel))
            {
                writer.WritePropertyName("updateChannel"u8);
                writer.WriteStringValue(UpdateChannel.Value.ToString());
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(StaticIP))
            {
                writer.WritePropertyName("staticIP"u8);
                writer.WriteStringValue(StaticIP.ToString());
            }
            writer.WriteEndObject();
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

        RedisCreateOrUpdateContent IJsonModel<RedisCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisCreateOrUpdateContent(document.RootElement, options);
        }

        internal static RedisCreateOrUpdateContent DeserializeRedisCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> zones = default;
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<RedisCommonConfiguration> redisConfiguration = default;
            Optional<string> redisVersion = default;
            Optional<bool> enableNonSslPort = default;
            Optional<int> replicasPerMaster = default;
            Optional<int> replicasPerPrimary = default;
            Optional<IDictionary<string, string>> tenantSettings = default;
            Optional<int> shardCount = default;
            Optional<RedisTlsVersion> minimumTlsVersion = default;
            Optional<RedisPublicNetworkAccess> publicNetworkAccess = default;
            Optional<UpdateChannel> updateChannel = default;
            RedisSku sku = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<IPAddress> staticIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("redisConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redisConfiguration = RedisCommonConfiguration.DeserializeRedisCommonConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("redisVersion"u8))
                        {
                            redisVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableNonSslPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableNonSslPort = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replicasPerMaster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicasPerMaster = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicasPerPrimary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicasPerPrimary = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tenantSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            tenantSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("shardCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shardCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new RedisTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new RedisPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("updateChannel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateChannel = new UpdateChannel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = RedisSku.DeserializeRedisSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("staticIP"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            staticIP = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisCreateOrUpdateContent(Optional.ToList(zones), location, Optional.ToDictionary(tags), identity, redisConfiguration.Value, redisVersion.Value, Optional.ToNullable(enableNonSslPort), Optional.ToNullable(replicasPerMaster), Optional.ToNullable(replicasPerPrimary), Optional.ToDictionary(tenantSettings), Optional.ToNullable(shardCount), Optional.ToNullable(minimumTlsVersion), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(updateChannel), sku, subnetId.Value, staticIP.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        RedisCreateOrUpdateContent IPersistableModel<RedisCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
