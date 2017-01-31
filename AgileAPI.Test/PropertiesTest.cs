// <copyright file="PropertiesTest.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI.Test
{
    using AgileAPI.Models;
    using Newtonsoft.Json;
    using Xunit;

    /// <summary>
    /// Tests the <see cref="ContactProperty"/> class.
    /// </summary>
    public class PropertiesTest
    {
        /// <summary>
        /// Tests the deserialization of a Json encoded property
        /// </summary>
        [Fact]
        public void Test1()
        {
            var propertyJson = "{" +
                "\"name\": \"Text field test\"," +
                "\"type\": \"CUSTOM\"," +
                "\"value\": \"I am text field test.\"" +
                "}";
            var property = JsonConvert.DeserializeObject<ContactProperty>(propertyJson);
            Assert.Equal("Text field test", property.Name);
            Assert.Equal(PropertyType.Custom, property.Type);
            Assert.Equal("I am text field test.", property.Value);
        }

        /// <summary>
        /// Tests the deserialization of a Json encoded property in case of a system property
        /// </summary>
        [Fact]
        public void Test2()
        {
            var propertyJson = "{" +
                "\"type\": \"SYSTEM\"," +
                "\"name\": \"image\"," +
                "\"value\":\"https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAkpAAAAJDY4ZDg2OTU3LTVhOTAtNGRlOC1hNjAxLTgwNGUyMzc0MDc2Mg.jpg\"" +
                "}";
            var property = JsonConvert.DeserializeObject<ContactProperty>(propertyJson);
            Assert.Equal("image", property.Name);
            Assert.Equal(PropertyType.System, property.Type);
            Assert.Equal("https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAkpAAAAJDY4ZDg2OTU3LTVhOTAtNGRlOC1hNjAxLTgwNGUyMzc0MDc2Mg.jpg", property.Value);
        }

        /// <summary>
        /// Tests the deserialization of a Json encoded property in case of a subtype
        /// </summary>
        [Fact]
        public void Test3()
        {
            var propertiesJson = "[\r\n        {\r\n            \"name\": \"Text field test\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"I am text field test.\"\r\n        },\r\n        {\r\n            \"name\": \"Text Area Test\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"I am text area field test. I am CEO of Uptake Technologies. I like Agile Chrome Extension. You can add leads from LinkedIn, Twitter, Facebook, Gmail etc.\"\r\n        },\r\n        {\r\n            \"name\": \"Date of Joining\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": 1279132200\r\n        },\r\n        {\r\n            \"name\": \"Please select checkbox to accept term and condition\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"on\"\r\n        },\r\n        {\r\n            \"name\": \"Please select one product from list\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"tomato\"\r\n        },\r\n        {\r\n            \"name\": \"Please add what are the companies you worked\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"[\\\"5694691248963584\\\",\\\"5646962099486720\\\"]\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"first_name\",\r\n            \"value\": \"Brad\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"last_name\",\r\n            \"value\": \"Keywell\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"image\",\r\n            \"value\": \"https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAkpAAAAJDY4ZDg2OTU3LTVhOTAtNGRlOC1hNjAxLTgwNGUyMzc0MDc2Mg.jpg\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"company\",\r\n            \"value\": \"Uptake Technologies\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"title\",\r\n            \"value\": \"\u200ECo-Founder and CEO\"\r\n        },\r\n        {\r\n            \"name\": \"email\",\r\n            \"value\": \"brad.keywell@yopmail.com\",\r\n            \"subtype\": \"work\"\r\n        },\r\n        {\r\n            \"name\": \"phone\",\r\n            \"value\": \"8888888888\",\r\n            \"subtype\": \"work\"\r\n        },\r\n        {\r\n            \"name\": \"website\",\r\n            \"value\": \"https://www.linkedin.com/in/bradkeywell\",\r\n            \"subtype\": \"LINKEDIN\"\r\n        },\r\n        {\r\n            \"name\": \"website\",\r\n            \"value\": \"https://www.youtube.com/watch?v=8-zQMprfDgE\",\r\n            \"subtype\": \"YOUTUBE\"\r\n        },\r\n        {\r\n            \"name\": \"address\",\r\n            \"value\": \"{\\\"address\\\":\\\"Motor City 120 street\\\",\\\"city\\\":\\\"Detroit\\\",\\\"state\\\":\\\"Michigan\\\",\\\"zip\\\":\\\"48201\\\",\\\"country\\\":\\\"US\\\",\\\"countryname\\\":\\\"United States\\\"}\"\r\n        }\r\n    ]";
            var properties = JsonConvert.DeserializeObject<ContactProperty[]>(propertiesJson);
            Assert.Equal(16, properties.Length);
        }

        [Fact]
        public void ContactTest()
        {
            var contactJson = "{\r\n    \"id\": \"5629585249009664\",\r\n    \"type\": \"PERSON\",\r\n    \"created_time\": \"1469170109\",\r\n    \"updated_time\": 1469764466,\r\n    \"last_contacted\": 0,\r\n    \"last_emailed\": 0,\r\n    \"last_campaign_emaild\": 0,\r\n    \"last_called\": 0,\r\n    \"viewed_time\": 0,\r\n    \"viewed\": {\r\n        \"viewed_time\": 1469764498855,\r\n        \"viewer_id\": 6263975862861824\r\n    },\r\n    \"star_value\": 4,\r\n    \"lead_score\": 5,\r\n    \"tags\": [],\r\n    \"tagsWithTime\": [\r\n        {\r\n            \"tag\": \"dummyTestTag\",\r\n            \"createdTime\": 1469510469602,\r\n            \"availableCount\": 0,\r\n            \"entity_type\": \"tag\"\r\n        }\r\n    ],\r\n    \"properties\": [\r\n        {\r\n            \"name\": \"Text field test\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"I am text field test.\"\r\n        },\r\n        {\r\n            \"name\": \"Text Area Test\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"I am text area field test. I am CEO of Uptake Technologies. I like Agile Chrome Extension. You can add leads from LinkedIn, Twitter, Facebook, Gmail etc.\"\r\n        },\r\n        {\r\n            \"name\": \"Date of Joining\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": 1279132200\r\n        },\r\n        {\r\n            \"name\": \"Please select checkbox to accept term and condition\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"on\"\r\n        },\r\n        {\r\n            \"name\": \"Please select one product from list\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"tomato\"\r\n        },\r\n        {\r\n            \"name\": \"Please add what are the companies you worked\",\r\n            \"type\": \"CUSTOM\",\r\n            \"value\": \"[\\\"5694691248963584\\\",\\\"5646962099486720\\\"]\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"first_name\",\r\n            \"value\": \"Brad\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"last_name\",\r\n            \"value\": \"Keywell\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"image\",\r\n            \"value\": \"https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAkpAAAAJDY4ZDg2OTU3LTVhOTAtNGRlOC1hNjAxLTgwNGUyMzc0MDc2Mg.jpg\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"company\",\r\n            \"value\": \"Uptake Technologies\"\r\n        },\r\n        {\r\n            \"type\": \"SYSTEM\",\r\n            \"name\": \"title\",\r\n            \"value\": \"\u200ECo-Founder and CEO\"\r\n        },\r\n        {\r\n            \"name\": \"email\",\r\n            \"value\": \"brad.keywell@yopmail.com\",\r\n            \"subtype\": \"work\"\r\n        },\r\n        {\r\n            \"name\": \"phone\",\r\n            \"value\": \"8888888888\",\r\n            \"subtype\": \"work\"\r\n        },\r\n        {\r\n            \"name\": \"website\",\r\n            \"value\": \"https://www.linkedin.com/in/bradkeywell\",\r\n            \"subtype\": \"LINKEDIN\"\r\n        },\r\n        {\r\n            \"name\": \"website\",\r\n            \"value\": \"https://www.youtube.com/watch?v=8-zQMprfDgE\",\r\n            \"subtype\": \"YOUTUBE\"\r\n        },\r\n        {\r\n            \"name\": \"address\",\r\n            \"value\": \"{\\\"address\\\":\\\"Motor City 120 street\\\",\\\"city\\\":\\\"Detroit\\\",\\\"state\\\":\\\"Michigan\\\",\\\"zip\\\":\\\"48201\\\",\\\"country\\\":\\\"US\\\",\\\"countryname\\\":\\\"United States\\\"}\"\r\n        }\r\n    ],\r\n    \"campaignStatus\": [],\r\n    \"entity_type\": \"contact_entity\",\r\n    \"contact_company_id\": \"5649189358796800\",\r\n    \"unsubscribeStatus\": [],\r\n    \"emailBounceStatus\": [],\r\n    \"formId\": 0,\r\n    \"owner\": {\r\n        \"id\": 6263975862861824,\r\n        \"domain\": \"ghanshyam\",\r\n        \"email\": \"ghanshyam.raut@agilecrm.com\",\r\n        \"name\": \"Ghanshyam\",\r\n        \"pic\": \"https://d1gwclp1pmzk26.cloudfront.net/img/gravatar/25.png\",\r\n        \"schedule_id\": \"Ghanshyam\",\r\n        \"calendar_url\": \"https://ghanshyam.agilecrm.com/calendar/Ghanshyam\",\r\n        \"calendarURL\": \"https://ghanshyam.agilecrm.com/calendar/Ghanshyam\"\r\n    }\r\n}";
            var contact = JsonConvert.DeserializeObject<Contact>(contactJson);
            Assert.Equal(5629585249009664, contact.Id);
            Assert.Equal(ContactType.Person, contact.Type);
            Assert.Equal(1469170109, contact.CreatedTime);
            Assert.Equal(1469764466, contact.UpdateTime);
            Assert.Equal(0, contact.LastContacted);
            Assert.Equal(0, contact.LastEmailed);
            Assert.Equal(0, contact.LastCampaignEmailed);
            Assert.Equal(0, contact.LastCalled);
            Assert.Equal(0, contact.ViewedTime);
            Assert.NotNull(contact.Viewed);
            Assert.Equal(4, contact.StarValue);
            Assert.Equal(5, contact.LeadScore);
            Assert.Equal(0, contact.Tags.Count);
            Assert.Equal(1, contact.TimedTags.Count);
            Assert.Equal(16, contact.Properties.Count);
            Assert.Equal("contact_entity", contact.EntityType);
            Assert.Equal(5649189358796800, contact.CompanyId);
            Assert.NotNull(contact.Owner);
        }

        /// <summary>
        /// Test the deserialization to a <see cref="Owner"/> object.
        /// </summary>
        [Fact]
        public void OwnerTest()
        {
            var ownerJson = "{\r\n        \"id\": 6263975862861824,\r\n        \"domain\": \"ghanshyam\",\r\n        \"email\": \"ghanshyam.raut@agilecrm.com\",\r\n        \"name\": \"Ghanshyam\",\r\n        \"pic\": \"https://d1gwclp1pmzk26.cloudfront.net/img/gravatar/25.png\",\r\n        \"schedule_id\": \"Ghanshyam\",\r\n        \"calendar_url\": \"https://ghanshyam.agilecrm.com/calendar/Ghanshyam\",\r\n        \"calendarURL\": \"https://ghanshyam.agilecrm.com/calendar/Ghanshyam\"\r\n    }";
            var owner = JsonConvert.DeserializeObject<Owner>(ownerJson);
            Assert.Equal(6263975862861824, owner.Id);
            Assert.Equal("ghanshyam", owner.Domain);
            Assert.Equal("ghanshyam.raut@agilecrm.com", owner.Email);
            Assert.Equal("Ghanshyam", owner.Name);
            Assert.Equal("https://ghanshyam.agilecrm.com/calendar/Ghanshyam", owner.CalendarUrl);
            Assert.Equal("https://d1gwclp1pmzk26.cloudfront.net/img/gravatar/25.png", owner.Picture);
            Assert.Equal("Ghanshyam", owner.ScheduleId);
        }

        /// <summary>
        /// Tests the deserialization to a <see cref="TimedTag"/> object
        /// </summary>
        [Fact]
        public void TimedTagTest()
        {
            var timedTagJson = "{\r\n            \"tag\": \"dummyTestTag\",\r\n            \"createdTime\": 1469510469602,\r\n            \"availableCount\": 0,\r\n            \"entity_type\": \"tag\"\r\n        }";
            var timedTag = JsonConvert.DeserializeObject<TimedTag>(timedTagJson);
            Assert.Equal("dummyTestTag", timedTag.Tag);
            Assert.Equal(1469510469602, timedTag.CreatedTime);
            Assert.Equal(0, timedTag.AvailableCount);
            Assert.Equal("tag", timedTag.EntityType);
        }

        /// <summary>
        /// Tests the deserialization to a <see cref="ContactViewed"/> object.
        /// </summary>
        [Fact]
        public void ViewedTest()
        {
            var viewedJson = "{\r\n        \"viewed_time\": 1469764498855,\r\n        \"viewer_id\": 6263975862861824\r\n    }";
            var viewed = JsonConvert.DeserializeObject<ContactViewed>(viewedJson);
            Assert.Equal(6263975862861824, viewed.ViewerId);
            Assert.Equal(1469764498855, viewed.ViewedTime);
        }
    }
}
