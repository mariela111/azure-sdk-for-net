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
    using System.Linq;

    /// <summary>
    /// The datastore details of the MT.
    /// </summary>
    public partial class DataStore
    {
        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        public DataStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStore class.
        /// </summary>
        /// <param name="symbolicName">The symbolic name of data store.</param>
        /// <param name="uuid">The uuid of data store.</param>
        /// <param name="capacity">The capacity of data store in GBs.</param>
        /// <param name="freeSpace">The free space of data store in
        /// GBs.</param>
        /// <param name="type">The type of data store.</param>
        public DataStore(string symbolicName = default(string), string uuid = default(string), string capacity = default(string), string freeSpace = default(string), string type = default(string))
        {
            SymbolicName = symbolicName;
            Uuid = uuid;
            Capacity = capacity;
            FreeSpace = freeSpace;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the symbolic name of data store.
        /// </summary>
        [JsonProperty(PropertyName = "symbolicName")]
        public string SymbolicName { get; set; }

        /// <summary>
        /// Gets or sets the uuid of data store.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or sets the capacity of data store in GBs.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// Gets or sets the free space of data store in GBs.
        /// </summary>
        [JsonProperty(PropertyName = "freeSpace")]
        public string FreeSpace { get; set; }

        /// <summary>
        /// Gets or sets the type of data store.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}