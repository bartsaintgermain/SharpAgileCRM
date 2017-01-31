// <copyright file="ContactViewed.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the view information of a contact
    /// </summary>
    public class ContactViewed
    {
        /// <summary>
        /// Gets or sets the viewed time.
        /// </summary>
        [JsonProperty("viewed_time")]
        public long ViewedTime { get; set; }

        /// <summary>
        /// Gets or sets the viewer id
        /// </summary>
        [JsonProperty("viewer_id")]
        public long ViewerId { get; set; }
    }
}
