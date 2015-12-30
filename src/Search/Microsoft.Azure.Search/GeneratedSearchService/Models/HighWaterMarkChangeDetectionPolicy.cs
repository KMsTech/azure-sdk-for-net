// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines a data change detection policy that captures changes based on
    /// the value of a high water mark column.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.HighWaterMarkChangeDetectionPolicy")]
    public partial class HighWaterMarkChangeDetectionPolicy : DataChangeDetectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HighWaterMarkChangeDetectionPolicy class.
        /// </summary>
        public HighWaterMarkChangeDetectionPolicy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// HighWaterMarkChangeDetectionPolicy class.
        /// </summary>
        public HighWaterMarkChangeDetectionPolicy(string highWaterMarkColumnName)
        {
            HighWaterMarkColumnName = highWaterMarkColumnName;
        }

        /// <summary>
        /// Gets or sets the name of the high water mark column.
        /// </summary>
        [JsonProperty(PropertyName = "highWaterMarkColumnName")]
        public string HighWaterMarkColumnName { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (HighWaterMarkColumnName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HighWaterMarkColumnName");
            }
        }
    }
}