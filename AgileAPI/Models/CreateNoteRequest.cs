// <copyright file="CreateNoteRequest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to create a note and relate it to contacts in the <c>crm</c>
    /// </summary>
    public class CreateNoteRequest
    {
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
        /// Gets or sets the related contact identifiers.
        /// </summary>
        [JsonProperty("contact_ids")]
        public List<long> ContactIds { get; set; }
    }
}
