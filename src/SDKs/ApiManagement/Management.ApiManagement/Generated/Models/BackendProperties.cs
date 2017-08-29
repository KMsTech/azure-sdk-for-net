// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties specific to the Backend Type.
    /// </summary>
    public partial class BackendProperties
    {
        /// <summary>
        /// Initializes a new instance of the BackendProperties class.
        /// </summary>
        public BackendProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendProperties class.
        /// </summary>
        /// <param name="serviceFabricCluster">Backend Service Fabric Cluster
        /// Properties</param>
        public BackendProperties(BackendServiceFabricClusterProperties serviceFabricCluster = default(BackendServiceFabricClusterProperties))
        {
            ServiceFabricCluster = serviceFabricCluster;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backend Service Fabric Cluster Properties
        /// </summary>
        [JsonProperty(PropertyName = "serviceFabricCluster")]
        public BackendServiceFabricClusterProperties ServiceFabricCluster { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServiceFabricCluster != null)
            {
                ServiceFabricCluster.Validate();
            }
        }
    }
}