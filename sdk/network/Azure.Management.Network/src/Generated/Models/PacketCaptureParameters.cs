// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters that define the create packet capture operation. </summary>
    public partial class PacketCaptureParameters
    {
        /// <summary> Initializes a new instance of PacketCaptureParameters. </summary>
        /// <param name="target"> The ID of the targeted resource, only VM is currently supported. </param>
        /// <param name="storageLocation"> The storage location for a packet capture session. </param>
        public PacketCaptureParameters(string target, PacketCaptureStorageLocation storageLocation)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            if (storageLocation == null)
            {
                throw new ArgumentNullException(nameof(storageLocation));
            }

            Target = target;
            StorageLocation = storageLocation;
        }

        /// <summary> Initializes a new instance of PacketCaptureParameters. </summary>
        /// <param name="target"> The ID of the targeted resource, only VM is currently supported. </param>
        /// <param name="bytesToCapturePerPacket"> Number of bytes captured per packet, the remaining bytes are truncated. </param>
        /// <param name="totalBytesPerSession"> Maximum size of the capture output. </param>
        /// <param name="timeLimitInSeconds"> Maximum duration of the capture session in seconds. </param>
        /// <param name="storageLocation"> The storage location for a packet capture session. </param>
        /// <param name="filters"> A list of packet capture filters. </param>
        internal PacketCaptureParameters(string target, int? bytesToCapturePerPacket, int? totalBytesPerSession, int? timeLimitInSeconds, PacketCaptureStorageLocation storageLocation, IList<PacketCaptureFilter> filters)
        {
            Target = target;
            BytesToCapturePerPacket = bytesToCapturePerPacket;
            TotalBytesPerSession = totalBytesPerSession;
            TimeLimitInSeconds = timeLimitInSeconds;
            StorageLocation = storageLocation;
            Filters = filters;
        }

        /// <summary> The ID of the targeted resource, only VM is currently supported. </summary>
        public string Target { get; set; }
        /// <summary> Number of bytes captured per packet, the remaining bytes are truncated. </summary>
        public int? BytesToCapturePerPacket { get; set; }
        /// <summary> Maximum size of the capture output. </summary>
        public int? TotalBytesPerSession { get; set; }
        /// <summary> Maximum duration of the capture session in seconds. </summary>
        public int? TimeLimitInSeconds { get; set; }
        /// <summary> The storage location for a packet capture session. </summary>
        public PacketCaptureStorageLocation StorageLocation { get; set; }
        /// <summary> A list of packet capture filters. </summary>
        public IList<PacketCaptureFilter> Filters { get; set; }
    }
}
