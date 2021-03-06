// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage resource provider settings
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Settings : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Settings class.
        /// </summary>
        public Settings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Settings class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="type">Resource Type.</param>
        /// <param name="location">Resource Location.</param>
        /// <param name="retentionPeriodForDeletedStorageAccountsInDays">The
        /// number of days a deleted storage account is kept before being
        /// permanently deleted.</param>
        public Settings(string id = default(string), string name = default(string), string type = default(string), string location = default(string), int? retentionPeriodForDeletedStorageAccountsInDays = default(int?))
            : base(id, name, type, location)
        {
            RetentionPeriodForDeletedStorageAccountsInDays = retentionPeriodForDeletedStorageAccountsInDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of days a deleted storage account is kept
        /// before being permanently deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionPeriodForDeletedStorageAccountsInDays")]
        public int? RetentionPeriodForDeletedStorageAccountsInDays { get; set; }

    }
}
