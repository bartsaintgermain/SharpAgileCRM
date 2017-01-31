// <copyright file="EmailProperties.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AgileAPI.Models;

    /// <summary>
    /// Defines extension methods related to email properties for the <see cref="Contact"/> class
    /// </summary>
    public static class EmailProperties
    {
        /// <summary>
        /// Gets the work email property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the work email property of the contact
        /// </returns>
        public static ContactProperty GetWorkEmailProperty(this Contact contact)
        {
            return contact.FindProperty("work", "email");
        }

        /// <summary>
        /// Gets the personal email property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the personal email property of the contact
        /// </returns>
        public static ContactProperty GetPersonalEmailProperty(this Contact contact)
        {
            return contact.FindProperty("personal", "email");
        }
    }
}
