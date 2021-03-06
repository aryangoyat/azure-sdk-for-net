// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ImageOSDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("osType");
            writer.WriteStringValue(OsType.ToSerialString());
            writer.WritePropertyName("osState");
            writer.WriteStringValue(OsState.ToSerialString());
            if (Snapshot != null)
            {
                writer.WritePropertyName("snapshot");
                writer.WriteObjectValue(Snapshot);
            }
            if (ManagedDisk != null)
            {
                writer.WritePropertyName("managedDisk");
                writer.WriteObjectValue(ManagedDisk);
            }
            if (BlobUri != null)
            {
                writer.WritePropertyName("blobUri");
                writer.WriteStringValue(BlobUri);
            }
            if (Caching != null)
            {
                writer.WritePropertyName("caching");
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (DiskSizeGB != null)
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (StorageAccountType != null)
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (DiskEncryptionSet != null)
            {
                writer.WritePropertyName("diskEncryptionSet");
                writer.WriteObjectValue(DiskEncryptionSet);
            }
            writer.WriteEndObject();
        }

        internal static ImageOSDisk DeserializeImageOSDisk(JsonElement element)
        {
            OperatingSystemTypes osType = default;
            OperatingSystemStateTypes osState = default;
            SubResource snapshot = default;
            SubResource managedDisk = default;
            string blobUri = default;
            CachingTypes? caching = default;
            int? diskSizeGB = default;
            StorageAccountTypes? storageAccountType = default;
            SubResource diskEncryptionSet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString().ToOperatingSystemTypes();
                    continue;
                }
                if (property.NameEquals("osState"))
                {
                    osState = property.Value.GetString().ToOperatingSystemStateTypes();
                    continue;
                }
                if (property.NameEquals("snapshot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshot = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("managedDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedDisk = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("blobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingTypes();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new StorageAccountTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSet = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
            }
            return new ImageOSDisk(snapshot, managedDisk, blobUri, caching, diskSizeGB, storageAccountType, diskEncryptionSet, osType, osState);
        }
    }
}
