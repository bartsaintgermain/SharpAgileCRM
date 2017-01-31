// <copyright file="ContactProperty.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Represents a property of the contact
    /// </summary>
    public class ContactProperty
    {
        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the property.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PropertyType Type { get; set; }

        /// <summary>
        /// Gets or sets the sub type of the property. Sub type of the field. Only system properties like email will have the sub types.
        /// </summary>
        [JsonProperty("subtype", NullValueHandling = NullValueHandling.Ignore)]
        public string SubType { get; set; }

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
