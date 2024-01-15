// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusNetworkFunctionApplication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
            }
            writer.WriteEndObject();
        }

        internal static AzureOperatorNexusNetworkFunctionApplication DeserializeAzureOperatorNexusNetworkFunctionApplication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("artifactType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ArmTemplate": return AzureOperatorNexusNetworkFunctionArmTemplateApplication.DeserializeAzureOperatorNexusNetworkFunctionArmTemplateApplication(element);
                    case "ImageFile": return AzureOperatorNexusNetworkFunctionImageApplication.DeserializeAzureOperatorNexusNetworkFunctionImageApplication(element);
                }
            }
            return UnknownAzureOperatorNexusNetworkFunctionApplication.DeserializeUnknownAzureOperatorNexusNetworkFunctionApplication(element);
        }
    }
}
