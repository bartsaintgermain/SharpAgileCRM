// <copyright file="Contact.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Represents a contact in <c>AgileCRM</c>
    /// </summary>
    /// <see cref="https://github.com/agilecrm/rest-api"/>
    public class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Gets or sets the cursor of this contact.
        /// </summary>
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or sets the id for the contact. The unique id is generated when contact is created
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the contact. The type distinguishes a contact and a company.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContactType Type { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonProperty("created_time")]
        public long CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the updated time.
        /// </summary>
        [JsonProperty("updated_time")]
        public long UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the last contact time.
        /// </summary>
        [JsonProperty("last_contacted")]
        public long LastContacted { get; set; }

        /// <summary>
        /// Gets or sets the last email time.
        /// </summary>
        [JsonProperty("last_emailed")]
        public long LastEmailed { get; set; }

        /// <summary>
        /// Gets or sets the last call time.
        /// </summary>
        [JsonProperty("last_called")]
        public long LastCalled { get; set; }

        /// <summary>
        /// Gets or sets the viewed time.
        /// </summary>
        [JsonProperty("viewed_time")]
        public long ViewedTime { get; set; }

        /// <summary>
        /// Gets or sets the viewed time.
        /// </summary>
        [JsonProperty("viewed")]
        public ContactViewed Viewed { get; set; }

        /// <summary>
        /// Gets or sets the last campaign email time.
        /// </summary>
        [JsonProperty("last_campaign_emaild")]
        public long LastCampaignEmailed { get; set; }

        /// <summary>
        /// Gets or sets the tags on the contact. A tag name should start with an alphabet and can not contain special characters other than underscore and space.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string> { };

        /// <summary>
        /// Gets or sets the timed tags
        /// </summary>
        [JsonProperty("tagsWithTime")]
        public List<TimedTag> TimedTags { get; set; } = new List<TimedTag> { };

        /// <summary>
        /// Gets or sets the lead score of the contact.
        /// </summary>
        [JsonProperty("lead_score")]
        public int LeadScore { get; set; }

        /// <summary>
        /// Gets or sets the company id of the contact.
        /// </summary>
        [JsonProperty("contact_company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the star value of the contact. Rating of contact (Max value 5). This is not applicable for companies.
        /// </summary>
        [JsonProperty("star_value")]
        public short StarValue { get; set; }

        /// <summary>
        /// Gets or sets the properties if the contact.
        /// </summary>
        [JsonProperty("properties")]
        public List<ContactProperty> Properties { get; set; } = new List<ContactProperty> { };

        /// <summary>
        /// Gets or sets the entity type.
        /// </summary>
        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        /// <summary>
        /// Updates this contact with the information from the given contact
        /// </summary>
        /// <param name="contact">
        /// The contact used to update this contact.
        /// </param>
        public void Update(Contact contact)
        {
            this.Id = contact.Id;
            this.CompanyId = contact.CompanyId;
            this.CreatedTime = contact.CreatedTime;
            this.EntityType = contact.EntityType;
            this.LastCalled = contact.LastCalled;
            this.LastCampaignEmailed = contact.LastCampaignEmailed;
            this.LastContacted = contact.LastContacted;
            this.LastEmailed = contact.LastEmailed;
            this.LeadScore = contact.LeadScore;
            this.Owner = contact.Owner;
            this.Properties = contact.Properties;
            this.StarValue = contact.StarValue;
            this.Tags = contact.Tags;
            this.TimedTags = contact.TimedTags;
            this.Type = contact.Type;
            this.UpdateTime = contact.UpdateTime;
            this.Viewed = contact.Viewed;
            this.ViewedTime = contact.ViewedTime;
        }

        /// <summary>
        /// Removes all data related to the <c>CRM</c>
        /// </summary>
        public void DisconnectFromCRM()
        {
            this.CompanyId = 0;
            this.CreatedTime = 0;
            this.LastCalled = 0;
            this.LastCampaignEmailed = 0;
            this.LastContacted = 0;
            this.LastEmailed = 0;
            this.TimedTags = new List<TimedTag>();
            this.UpdateTime = 0;
            this.Viewed = null;
            this.ViewedTime = 0;
        }
    }
}
