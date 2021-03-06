// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ModelProperties
    {
        /// <summary>
        /// Initializes a new instance of the ModelProperties class.
        /// </summary>
        public ModelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelProperties class.
        /// </summary>
        public ModelProperties(System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?))
        {
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

    }
}
