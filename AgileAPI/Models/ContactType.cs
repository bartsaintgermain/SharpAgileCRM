// <copyright file="ContactType.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the contact type.
    /// </summary>
    public enum ContactType
    {
        /// <summary>
        /// The contact is a person
        /// </summary>
        [EnumMember(Value = "PERSON")]
        Person,

        /// <summary>
        /// The contact is a company
        /// </summary>
        [EnumMember(Value = "COMPANY")]
        Company,
    }
}
