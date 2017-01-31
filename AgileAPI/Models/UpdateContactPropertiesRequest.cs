// <copyright file="UpdateContactPropertiesRequest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to update the properties of a contact in the <c>crm</c>
    /// </summary>
    internal class UpdateContactPropertiesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactPropertiesRequest"/> class.
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        internal UpdateContactPropertiesRequest(Contact contact)
        {
            if (contact.Id == 0)
            {
                throw new ArgumentException(nameof(contact), "Contact Id cannot be '0'");
            }

            this.Id = contact.Id;
            this.Properties = contact.Properties;
        }

        /// <summary>
        /// Gets or sets the id for the contact. The unique id is generated when contact is created
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the properties if the contact.
        /// </summary>
        [JsonProperty("properties")]
        public List<ContactProperty> Properties { get; set; } = new List<ContactProperty> { };
    }
}
