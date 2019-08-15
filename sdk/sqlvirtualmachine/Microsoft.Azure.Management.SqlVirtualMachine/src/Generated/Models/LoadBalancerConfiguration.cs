// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SqlVirtualMachine.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A load balancer configuration for an availability group listener.
    /// </summary>
    public partial class LoadBalancerConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancerConfiguration class.
        /// </summary>
        public LoadBalancerConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancerConfiguration class.
        /// </summary>
        /// <param name="privateIpAddress">Private IP address.</param>
        /// <param name="publicIpAddressResourceId">Resource id of the public
        /// IP.</param>
        /// <param name="loadBalancerResourceId">Resource id of the load
        /// balancer.</param>
        /// <param name="probePort">Probe port.</param>
        /// <param name="sqlVirtualMachineInstances">List of the SQL virtual
        /// machine instance resource id's that are enrolled into the
        /// availability group listener.</param>
        public LoadBalancerConfiguration(PrivateIPAddress privateIpAddress = default(PrivateIPAddress), string publicIpAddressResourceId = default(string), string loadBalancerResourceId = default(string), int? probePort = default(int?), IList<string> sqlVirtualMachineInstances = default(IList<string>))
        {
            PrivateIpAddress = privateIpAddress;
            PublicIpAddressResourceId = publicIpAddressResourceId;
            LoadBalancerResourceId = loadBalancerResourceId;
            ProbePort = probePort;
            SqlVirtualMachineInstances = sqlVirtualMachineInstances;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets private IP address.
        /// </summary>
        [JsonProperty(PropertyName = "privateIpAddress")]
        public PrivateIPAddress PrivateIpAddress { get; set; }

        /// <summary>
        /// Gets or sets resource id of the public IP.
        /// </summary>
        [JsonProperty(PropertyName = "publicIpAddressResourceId")]
        public string PublicIpAddressResourceId { get; set; }

        /// <summary>
        /// Gets or sets resource id of the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerResourceId")]
        public string LoadBalancerResourceId { get; set; }

        /// <summary>
        /// Gets or sets probe port.
        /// </summary>
        [JsonProperty(PropertyName = "probePort")]
        public int? ProbePort { get; set; }

        /// <summary>
        /// Gets or sets list of the SQL virtual machine instance resource id's
        /// that are enrolled into the availability group listener.
        /// </summary>
        [JsonProperty(PropertyName = "sqlVirtualMachineInstances")]
        public IList<string> SqlVirtualMachineInstances { get; set; }

    }
}