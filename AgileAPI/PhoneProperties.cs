// <copyright file="PhoneProperties.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AgileAPI.Models;

    /// <summary>
    /// Defines extension methods related to phone properties for the <see cref="Contact"/> class
    /// </summary>
    internal static class PhoneProperties
    {
        /// <summary>
        /// Gets the work phone property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the work phone property of the contact
        /// </returns>
        public static ContactProperty GetWorkPhoneProperty(this Contact contact)
        {
            return contact.FindProperty("work", "phone");
        }

        /// <summary>
        /// Gets the home phone property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the home phone property of the contact
        /// </returns>
        public static ContactProperty GetHomePhoneProperty(this Contact contact)
        {
            return contact.FindProperty("home", "phone");
        }

        /// <summary>
        /// Gets the mobile phone property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the mobile phone property of the contact
        /// </returns>
        public static ContactProperty GetMobilePhoneProperty(this Contact contact)
        {
            return contact.FindProperty("mobile", "phone");
        }

        /// <summary>
        /// Gets the main phone property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the main phone property of the contact
        /// </returns>
        public static ContactProperty GetMainPhoneProperty(this Contact contact)
        {
            return contact.FindProperty("main", "phone");
        }

        /// <summary>
        /// Gets the fax property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the fax property of the contact
        /// </returns>
        public static ContactProperty GetFaxProperty(this Contact contact)
        {
            return contact.FindProperty("fax", "phone");
        }

        /// <summary>
        /// Gets the other phone property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the other phone property of the contact
        /// </returns>
        public static ContactProperty GetOtherPhoneProperty(this Contact contact)
        {
            return contact.FindProperty("other", "phone");
        }
    }
}
