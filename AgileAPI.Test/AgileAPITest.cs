// <copyright file="AgileAPITest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Test
{
    using Xunit;

    /// <summary>
    /// Tests the <see cref="AgileCRM"/> class
    /// </summary>
    public class AgileAPITest
    {
        /// <summary>
        /// Tests the <see cref="AgileCRM.GetUrl(string)"/> method.
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            var crm = new AgileCRM("quamotion", "email@mail.com", "apikey");
            Assert.Equal("https://quamotion.agilecrm.com/dev/api/contacts", crm.GetUrl("contacts"));
        }
    }
}
