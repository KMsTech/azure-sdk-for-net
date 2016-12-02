// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties for evaluating a policy set.
    /// </summary>
    public partial class EvaluatePoliciesProperties
    {
        /// <summary>
        /// Initializes a new instance of the EvaluatePoliciesProperties class.
        /// </summary>
        public EvaluatePoliciesProperties() { }

        /// <summary>
        /// Initializes a new instance of the EvaluatePoliciesProperties class.
        /// </summary>
        public EvaluatePoliciesProperties(string factName = default(string), string factData = default(string), string valueOffset = default(string))
        {
            FactName = factName;
            FactData = factData;
            ValueOffset = valueOffset;
        }

        /// <summary>
        /// The fact name.
        /// </summary>
        [JsonProperty(PropertyName = "factName")]
        public string FactName { get; set; }

        /// <summary>
        /// The fact data.
        /// </summary>
        [JsonProperty(PropertyName = "factData")]
        public string FactData { get; set; }

        /// <summary>
        /// The value offset.
        /// </summary>
        [JsonProperty(PropertyName = "valueOffset")]
        public string ValueOffset { get; set; }

    }
}