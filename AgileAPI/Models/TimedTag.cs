// <copyright file="TimedTag.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a timed tag.
    /// </summary>
    public class TimedTag
    {
        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets the creation time
        /// </summary>
        [JsonProperty("createdTime")]
        public long CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the available count
        /// </summary>
        [JsonProperty("availableCount")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// Gets or sets the  entity type
        /// </summary>
        [JsonProperty("entity_type")]
        public string EntityType { get; set; }
    }
}
