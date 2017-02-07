// <copyright file="Notes.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using AgileAPI.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This class provides support to handle with notes in the <c>CRM</c>
    /// </summary>
    public class Notes
    {
        /// <summary>
        /// Creates a note in the <c>CRM</c>
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance to be used.
        /// </param>
        /// <param name="subject">
        /// The subject of the note.
        /// </param>
        /// <param name="description">
        /// The description of the note.
        /// </param>
        /// <param name="contactIds">
        /// The related contact identifiers.
        /// </param>
        /// <returns>
        /// The created note
        /// </returns>
        public static async Task<Note> CreateContactNote(AgileCRM crm, string subject, string description, List<long> contactIds)
        {
            var createNoteRequest = new CreateNoteRequest()
            {
                Subject = subject,
                Description = description,
                ContactIds = contactIds,
            };

            var response = await crm.RequestAsync($"notes", HttpMethod.Post, null).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<Note>(response);
        }

        /// <summary>
        /// Get all notes related to a contact.
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance to be used.
        /// </param>
        /// <param name="contactId">
        /// The contact identifier for which to retrieve the note.
        /// </param>
        /// <returns>
        /// The notes related to a contact.
        /// </returns>
        public static async Task<List<Note>> GetContactNotes(AgileCRM crm, long contactId)
        {
            var response = await crm.RequestAsync($"contacts/{contactId}/notes", HttpMethod.Get, null).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<List<Note>>(response);
        }
    }
}
