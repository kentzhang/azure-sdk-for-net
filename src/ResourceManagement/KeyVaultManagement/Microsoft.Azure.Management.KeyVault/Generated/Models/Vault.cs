// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Resource information with extended details.
    /// </summary>
    public partial class Vault : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        public Vault() { }

        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        public Vault(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), VaultProperties properties = default(VaultProperties))
            : base(location, id, name, type, tags)
        {
            Properties = properties;
        }

        /// <summary>
        /// Properties of the vault
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VaultProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
