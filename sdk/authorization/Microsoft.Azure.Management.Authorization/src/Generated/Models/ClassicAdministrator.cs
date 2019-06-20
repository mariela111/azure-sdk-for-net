// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Classic Administrators
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClassicAdministrator
    {
        /// <summary>
        /// Initializes a new instance of the ClassicAdministrator class.
        /// </summary>
        public ClassicAdministrator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClassicAdministrator class.
        /// </summary>
        /// <param name="id">The ID of the administrator.</param>
        /// <param name="name">The name of the administrator.</param>
        /// <param name="type">The type of the administrator.</param>
        /// <param name="emailAddress">The email address of the
        /// administrator.</param>
        /// <param name="role">The role of the administrator.</param>
        public ClassicAdministrator(string id = default(string), string name = default(string), string type = default(string), string emailAddress = default(string), string role = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            EmailAddress = emailAddress;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the email address of the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the role of the administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.role")]
        public string Role { get; set; }

    }
}