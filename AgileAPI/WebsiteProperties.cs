// <copyright file="WebsiteProperties.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AgileAPI.Models;

    /// <summary>
    /// Defines extension methods related to website properties for the <see cref="Contact"/> class
    /// </summary>
    internal static class WebsiteProperties
    {
        /// <summary>
        /// Gets the website property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the website property of the contact
        /// </returns>
        public static ContactProperty GetWebsiteProperty(this Contact contact)
        {
            return contact.FindProperty("URL", "website");
        }

        /// <summary>
        /// Gets the skype property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the skype property of the contact
        /// </returns>
        public static ContactProperty GetSkypeProperty(this Contact contact)
        {
            return contact.FindProperty("SKYPE", "website");
        }

        /// <summary>
        /// Gets the twitter property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the twitter property of the contact
        /// </returns>
        public static ContactProperty GetTwitterProperty(this Contact contact)
        {
            return contact.FindProperty("TWITTER", "website");
        }

        /// <summary>
        /// Gets the LinkedIn property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the LinkedIn property of the contact
        /// </returns>
        public static ContactProperty GetLinkedInProperty(this Contact contact)
        {
            return contact.FindProperty("LINKEDIN", "website");
        }

        /// <summary>
        /// Gets the Facebook property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the Facebook property of the contact
        /// </returns>
        public static ContactProperty GetFacebookProperty(this Contact contact)
        {
            return contact.FindProperty("FACEBOOK", "website");
        }

        /// <summary>
        /// Gets the Xing property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the Xing property of the contact
        /// </returns>
        public static ContactProperty GetXingProperty(this Contact contact)
        {
            return contact.FindProperty("XING", "website");
        }

        /// <summary>
        /// Gets the FEED property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the FEED property of the contact
        /// </returns>
        public static ContactProperty GetFeedProperty(this Contact contact)
        {
            return contact.FindProperty("FEED", "website");
        }

        /// <summary>
        /// Gets the GOOGLE_PLUS property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the GOOGLE_PLUS property of the contact
        /// </returns>
        public static ContactProperty GetGooglePlusProperty(this Contact contact)
        {
            return contact.FindProperty("GOOGLE_PLUS", "website");
        }

        /// <summary>
        /// Gets the FLICKR property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the FLICKR property of the contact
        /// </returns>
        public static ContactProperty GetFlickRProperty(this Contact contact)
        {
            return contact.FindProperty("FLICKR", "website");
        }

        /// <summary>
        /// Gets the GITHUB property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the GITHUB property of the contact
        /// </returns>
        public static ContactProperty GetGitHubProperty(this Contact contact)
        {
            return contact.FindProperty("GITHUB", "website");
        }

        /// <summary>
        /// Gets the YOUTUBE property of the contact
        /// </summary>
        /// <param name="contact">
        /// The contact
        /// </param>
        /// <returns>
        /// the YOUTUBE property of the contact
        /// </returns>
        public static ContactProperty GetYouTubeProperty(this Contact contact)
        {
            return contact.FindProperty("YOUTUBE", "website");
        }
    }
}
