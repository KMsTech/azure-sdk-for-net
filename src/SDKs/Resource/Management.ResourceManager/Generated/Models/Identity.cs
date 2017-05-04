// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public partial class Identity
    {
        /// <summary>
        /// Initializes a new instance of the Identity class.
        /// </summary>
        public Identity() { }

        /// <summary>
        /// Initializes a new instance of the Identity class.
        /// </summary>
        /// <param name="principalId">The principal ID of resource
        /// identity.</param>
        /// <param name="tenantId">The tenant ID of resource.</param>
        /// <param name="type">The identity type. Possible values include:
        /// 'SystemAssigned'</param>
        public Identity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary>
        /// Gets the principal ID of resource identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant ID of resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the identity type. Possible values include:
        /// 'SystemAssigned'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public ResourceIdentityType? Type { get; set; }

    }
}