// <copyright file="PropertyType.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the type of the property.
    /// </summary>
    public enum PropertyType
    {
        /// <summary>
        /// The contact is a person
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        System,

        /// <summary>
        /// The contact is a company
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        Custom,
    }
}
