// <copyright file="Owner.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the owner of the contact.
    /// </summary>
    public class Owner
    {
        /// <summary>
        /// Gets or sets the id of the owner.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the domain of the owner
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the name of the owner
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the owner
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the picture of the owner
        /// </summary>
        [JsonProperty("pic")]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or sets the schedule id of the owner
        /// </summary>
        [JsonProperty("schedule_id")]
        public string ScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the calendar url of the owner
        /// </summary>
        [JsonProperty("calendarURL")]
        public string CalendarUrl { get; set; }
    }
}
