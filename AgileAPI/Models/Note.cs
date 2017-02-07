// <copyright file="Note.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a note in the <c>CRM</c>
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Gets or sets the id of the note.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the note.
        /// </summary>
        [JsonProperty("created_time")]
        public long CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the subject of the note.
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the description of the note.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the entity type.
        /// </summary>
        [JsonProperty("entity_type")]
        public string EntityType { get; set; }
    }
}
