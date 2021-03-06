// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters that define the operation to create a connection monitor. </summary>
    public partial class ConnectionMonitorParameters
    {
        /// <summary> Initializes a new instance of ConnectionMonitorParameters. </summary>
        public ConnectionMonitorParameters()
        {
        }

        /// <summary> Initializes a new instance of ConnectionMonitorParameters. </summary>
        /// <param name="source"> Describes the source of connection monitor. </param>
        /// <param name="destination"> Describes the destination of connection monitor. </param>
        /// <param name="autoStart"> Determines if the connection monitor will start automatically once created. </param>
        /// <param name="monitoringIntervalInSeconds"> Monitoring interval in seconds. </param>
        /// <param name="endpoints"> List of connection monitor endpoints. </param>
        /// <param name="testConfigurations"> List of connection monitor test configurations. </param>
        /// <param name="testGroups"> List of connection monitor test groups. </param>
        /// <param name="outputs"> List of connection monitor outputs. </param>
        /// <param name="notes"> Optional notes to be associated with the connection monitor. </param>
        internal ConnectionMonitorParameters(ConnectionMonitorSource source, ConnectionMonitorDestination destination, bool? autoStart, int? monitoringIntervalInSeconds, IList<ConnectionMonitorEndpoint> endpoints, IList<ConnectionMonitorTestConfiguration> testConfigurations, IList<ConnectionMonitorTestGroup> testGroups, IList<ConnectionMonitorOutput> outputs, string notes)
        {
            Source = source;
            Destination = destination;
            AutoStart = autoStart;
            MonitoringIntervalInSeconds = monitoringIntervalInSeconds;
            Endpoints = endpoints;
            TestConfigurations = testConfigurations;
            TestGroups = testGroups;
            Outputs = outputs;
            Notes = notes;
        }

        /// <summary> Describes the source of connection monitor. </summary>
        public ConnectionMonitorSource Source { get; set; }
        /// <summary> Describes the destination of connection monitor. </summary>
        public ConnectionMonitorDestination Destination { get; set; }
        /// <summary> Determines if the connection monitor will start automatically once created. </summary>
        public bool? AutoStart { get; set; }
        /// <summary> Monitoring interval in seconds. </summary>
        public int? MonitoringIntervalInSeconds { get; set; }
        /// <summary> List of connection monitor endpoints. </summary>
        public IList<ConnectionMonitorEndpoint> Endpoints { get; set; }
        /// <summary> List of connection monitor test configurations. </summary>
        public IList<ConnectionMonitorTestConfiguration> TestConfigurations { get; set; }
        /// <summary> List of connection monitor test groups. </summary>
        public IList<ConnectionMonitorTestGroup> TestGroups { get; set; }
        /// <summary> List of connection monitor outputs. </summary>
        public IList<ConnectionMonitorOutput> Outputs { get; set; }
        /// <summary> Optional notes to be associated with the connection monitor. </summary>
        public string Notes { get; set; }
    }
}
