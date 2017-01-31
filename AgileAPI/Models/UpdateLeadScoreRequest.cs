// <copyright file="UpdateLeadScoreRequest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to update the lead score of a contact in the <c>crm</c>
    /// </summary>
    internal class UpdateLeadScoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLeadScoreRequest"/> class.
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        internal UpdateLeadScoreRequest(Contact contact)
        {
            if (contact.Id == 0)
            {
                throw new ArgumentException(nameof(contact), "Contact Id cannot be '0'");
            }

            this.Id = contact.Id;
            this.LeadScore = contact.LeadScore;
        }

        /// <summary>
        /// Gets or sets the id for the contact. The unique id is generated when contact is created
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the lead score of the contact.
        /// </summary>
        [JsonProperty("lead_score")]
        public int LeadScore { get; set; }
    }
}
