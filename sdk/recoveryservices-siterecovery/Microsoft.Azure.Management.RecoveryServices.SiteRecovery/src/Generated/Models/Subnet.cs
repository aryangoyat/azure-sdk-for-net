// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Subnets of the network.
    /// </summary>
    public partial class Subnet
    {
        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        public Subnet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        /// <param name="name">The subnet name.</param>
        /// <param name="friendlyName">The subnet friendly name.</param>
        /// <param name="addressList">The list of addresses for the
        /// subnet.</param>
        public Subnet(string name = default(string), string friendlyName = default(string), IList<string> addressList = default(IList<string>))
        {
            Name = name;
            FriendlyName = friendlyName;
            AddressList = addressList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subnet friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the list of addresses for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "addressList")]
        public IList<string> AddressList { get; set; }

    }
}