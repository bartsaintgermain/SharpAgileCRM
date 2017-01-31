// <copyright file="AddressProperties.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using AgileAPI.Models;

    /// <summary>
    /// Defines extension methods related to address properties for the <see cref="Contact"/> class
    /// </summary>
    public static class AddressProperties
    {
        /// <summary>
        /// Gets the home address property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the home address property of the contact
        /// </returns>
        public static ContactProperty GetHomeAddressProperty(this Contact contact)
        {
            return contact.FindProperty("home", "address");
        }

        /// <summary>
        /// Gets the postal address property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the postal address property of the contact
        /// </returns>
        public static ContactProperty GetPostalAddressProperty(this Contact contact)
        {
            return contact.FindProperty("postal", "address");
        }

        /// <summary>
        /// Gets the office address property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the office address property of the contact
        /// </returns>
        public static ContactProperty GetOfficeAddressProperty(this Contact contact)
        {
            return contact.FindProperty("office", "address");
        }
    }
}
