// <copyright file="PersonProperties.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AgileAPI.Models;

    /// <summary>
    /// Defines extension methods related to person properties for the <see cref="Contact"/> class
    /// </summary>
    internal static class PersonProperties
    {
        /// <summary>
        /// Gets the first_name property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the first_name property of the contact
        /// </returns>
        public static ContactProperty GetFirstNameProperty(this Contact contact)
        {
            return contact.FindProperty(PropertyType.System, "first_name");
        }

        /// <summary>
        /// Gets the last_name property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the last_name property of the contact
        /// </returns>
        public static ContactProperty GetLastNameProperty(this Contact contact)
        {
            return contact.FindProperty(PropertyType.System, "last_name");
        }

        /// <summary>
        /// Gets the image property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the image property of the contact
        /// </returns>
        public static ContactProperty GetImageProperty(this Contact contact)
        {
            return contact.FindProperty(PropertyType.System, "image");
        }

        /// <summary>
        /// Gets the company property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the company property of the contact
        /// </returns>
        public static ContactProperty GetCompanyProperty(this Contact contact)
        {
            return contact.FindProperty(PropertyType.System, "company");
        }

        /// <summary>
        /// Gets the title property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the title property of the contact
        /// </returns>
        public static ContactProperty GetTitleProperty(this Contact contact)
        {
            return contact.FindProperty(PropertyType.System, "title");
        }
    }
}
