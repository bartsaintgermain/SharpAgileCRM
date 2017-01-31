// <copyright file="NewPersonRequest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to add a person to the <c>crm</c>
    /// </summary>
    internal class NewPersonRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPersonRequest"/> class.
        /// </summary>
        /// <param name="person">
        /// The <see cref="Person"/> object used to initialize this request.
        /// </param>
        public NewPersonRequest(Person person)
        {
            if (person.Contact == null)
            {
                throw new ArgumentException(nameof(person), "The person has no contact.");
            }

            this.Properties = person.Contact.Properties;
            this.Tags = person.Contact.Tags;
            this.LeadScore = person.Contact.LeadScore;
            this.StarValue = person.Contact.StarValue;
        }

        /// <summary>
        /// Gets or sets the star value of the contact. Rating of contact (Max value 5). This is not applicable for companies.
        /// </summary>
        [JsonProperty("star_value")]
        public short StarValue { get; set; }

        /// <summary>
        /// Gets or sets the lead score of the contact.
        /// </summary>
        [JsonProperty("lead_score")]
        public int LeadScore { get; set; }

        /// <summary>
        /// Gets or sets the tags on the contact. A tag name should start with an alphabet and can not contain special characters other than underscore and space.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string> { };

        /// <summary>
        /// Gets or sets the properties if the contact.
        /// </summary>
        [JsonProperty("properties")]
        public List<ContactProperty> Properties { get; set; } = new List<ContactProperty> { };
    }
}
