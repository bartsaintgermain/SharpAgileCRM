// <copyright file="UpdateContactTagsRequest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to update the tags of a contact in the <c>crm</c>
    /// </summary>
    internal class UpdateContactTagsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactTagsRequest"/> class.
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <param name="tags">
        /// The tags to be updated.
        /// </param>
        internal UpdateContactTagsRequest(Contact contact, List<string> tags)
        {
            if (contact.Id == 0)
            {
                throw new ArgumentException(nameof(contact), "Contact Id cannot be '0'");
            }

            this.Id = contact.Id;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or sets the id for the contact. The unique id is generated when contact is created
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the tags on the contact. A tag name should start with an alphabet and can not contain special characters other than underscore and space.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string> { };
    }
}
