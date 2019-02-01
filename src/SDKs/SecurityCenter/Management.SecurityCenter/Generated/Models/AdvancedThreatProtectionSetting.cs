// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Advanced Threat Protection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AdvancedThreatProtectionSetting : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AdvancedThreatProtectionSetting
        /// class.
        /// </summary>
        public AdvancedThreatProtectionSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdvancedThreatProtectionSetting
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="isEnabled">Indicates whether Advanced Threat
        /// Protection is enabled.</param>
        public AdvancedThreatProtectionSetting(string id = default(string), string name = default(string), string type = default(string), bool? isEnabled = default(bool?))
            : base(id, name, type)
        {
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether Advanced Threat Protection is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; set; }

    }
}