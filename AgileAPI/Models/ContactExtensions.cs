// <copyright file="ContactExtensions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System.Linq;

    /// <summary>
    /// Defines general extension methods on the <see cref="Contact"/> class.
    /// </summary>
    public static class ContactExtensions
    {
        /// <summary>
        /// Finds a contact property based on the property type and name
        /// </summary>
        /// <param name="contact">
        /// The <see cref="Contact"/> instance.
        /// </param>
        /// <param name="type">
        /// The type of the property to be found
        /// </param>
        /// <param name="name">
        /// The name of the property to be found.
        /// </param>
        /// <returns>
        /// The <see cref="ContactProperty"/> matching the given name and the type
        /// </returns>
        public static ContactProperty FindProperty(this Contact contact, PropertyType type, string name)
        {
            var properties = contact.Properties.Where(p => p.Name == name && p.Type == type);

            if (properties.Count() == 0)
            {
                var property = new ContactProperty()
                {
                    Name = name,
                    Type = type,
                };

                contact.Properties.Add(property);
                return property;
            }
            else
            {
                return properties.Single();
            }
        }

        /// <summary>
        /// Finds a contact property based on the property type, subtype and name
        /// </summary>
        /// <param name="contact">
        /// The <see cref="Contact"/> instance.
        /// </param>
        /// <param name="subType">
        /// The subtype of the property to be found
        /// </param>
        /// <param name="name">
        /// The name of the property to be found.
        /// </param>
        /// <returns>
        /// The <see cref="ContactProperty"/> matching the given name and the type
        /// </returns>
        public static ContactProperty FindProperty(this Contact contact, string subType, string name)
        {
            var properties = contact.Properties.Where(p => p.SubType == subType && p.Name == name);

            if (properties.Count() == 0)
            {
                var property = new ContactProperty()
                {
                    Name = name,
                    SubType = subType,
                };

                contact.Properties.Add(property);
                return property;
            }
            else
            {
                return properties.Single();
            }
        }

        /// <summary>
        /// Sets the value of the given property
        /// </summary>
        /// <param name="contact">
        /// The <see cref="Contact"/> instance
        /// </param>
        /// <param name="name">
        /// The name of the property
        /// </param>
        /// <param name="value">
        /// The value to be set.
        /// </param>
        public static void SetProperty(this Contact contact, string name, string value)
        {
            var property = contact.FindProperty(PropertyType.Custom, name);
            property.Value = value;
        }

        /// <summary>
        /// Gets the value of the given property
        /// </summary>
        /// <param name="contact">
        /// The <see cref="Contact"/> instance
        /// </param>
        /// <param name="name">
        /// The name of the property
        /// </param>
        /// <returns>
        /// the value of the given properties
        /// </returns>
        public static string GetProperty(this Contact contact, string name)
        {
            var property = contact.FindProperty(PropertyType.Custom, name);
            return property.Value;
        }
    }
}
