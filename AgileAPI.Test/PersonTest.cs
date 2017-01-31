// <copyright file="PersonTest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Test
{
    using Xunit;

    /// <summary>
    /// Tests the <see cref="Person"/> class
    /// </summary>
    public class PersonTest
    {
        /// <summary>
        /// Tests the initialization of a <see cref="Person"/> object
        /// </summary>
        [Fact]
        public void PersonConstructorTest()
        {
            var person = new Person()
            {
                CompanyName = "Quamotion",
                Email = "saintplacie@gmail.com",
                FirstName = "Nele",
                LastName = "Duplacie",
                Phone = "0479912076",
                Website = "quamotion.mobi",
            };

            Assert.Equal("Quamotion", person.CompanyName);
            Assert.Equal("saintplacie@gmail.com", person.Email);
            Assert.Equal("Nele", person.FirstName);
            Assert.Equal("Duplacie", person.LastName);
            Assert.Equal("0479912076", person.Phone);
            Assert.Equal("quamotion.mobi", person.Website);
        }
    }
}
