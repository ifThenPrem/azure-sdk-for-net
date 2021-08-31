// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Containers.ContainerRegistry.Specialized;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class V2Manifest
    {
        internal static V2Manifest DeserializeV2Manifest(JsonElement element)
        {
            Optional<string> mediaType = default;
            Optional<ArtifactBlobDescriptor> config = default;
            Optional<IReadOnlyList<ArtifactBlobDescriptor>> layers = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("config"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    config = ArtifactBlobDescriptor.DeserializeArtifactBlobDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ArtifactBlobDescriptor> array = new List<ArtifactBlobDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArtifactBlobDescriptor.DeserializeArtifactBlobDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new V2Manifest(Optional.ToNullable(schemaVersion), mediaType.Value, config.Value, Optional.ToList(layers));
        }
    }
}
