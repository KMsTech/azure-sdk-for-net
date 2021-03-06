// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
	using System.Linq;
	using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;

    /// <summary>
    /// Role definition.
    /// </summary>
    public partial class RoleDefinition
    {
        /// <summary>
        /// Initializes a new instance of the RoleDefinition class.
        /// </summary>
        public RoleDefinition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDefinition class.
        /// </summary>
        /// <param name="id">The role definition ID.</param>
        /// <param name="name">The role definition name.</param>
        /// <param name="type">The role definition type.</param>
        /// <param name="properties">Role definition properties.</param>
        public RoleDefinition(string id = default(string), string name = default(string), string type = default(string), RoleDefinitionProperties properties = default(RoleDefinitionProperties))
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the role definition ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the role definition name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role definition type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets role definition properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RoleDefinitionProperties Properties { get; set; }

    }
}
