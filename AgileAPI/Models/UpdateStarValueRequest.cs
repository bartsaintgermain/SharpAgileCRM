// <copyright file="UpdateStarValueRequest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to update the star value of a contact in the <c>crm</c>
    /// </summary>
    internal class UpdateStarValueRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStarValueRequest"/> class.
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        internal UpdateStarValueRequest(Contact contact)
        {
            if (contact.Id == 0)
            {
                throw new ArgumentException(nameof(contact), "Contact Id cannot be '0'");
            }

            this.Id = contact.Id;
            this.StarValue = contact.StarValue;
        }

        /// <summary>
        /// Gets or sets the id for the contact. The unique id is generated when contact is created
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the star value of the contact. Rating of contact (Max value 5). This is not applicable for companies.
        /// </summary>
        [JsonProperty("star_value")]
        public short StarValue { get; set; }
    }
}
