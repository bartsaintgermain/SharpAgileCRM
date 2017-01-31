// <copyright file="Person.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using AgileAPI.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a person in the CRM
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
            : this(new Contact())
        {
            this.Contact.Type = ContactType.Person;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="id">
        /// The id of the person
        /// </param>
        public Person(long id)
            : this()
        {
            this.Contact.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="email">
        /// The id of the person
        /// </param>
        public Person(string email)
            : this()
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name of the person
        /// </param>
        /// <param name="lastName">
        /// The last name of the person
        /// </param>
        /// <param name="email">
        /// The email of the person
        /// </param>
        /// <param name="address">
        /// The address of the person
        /// </param>
        public Person(string firstName, string lastName, string email, string address)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="contact">
        /// The associated <see cref="Contact"/>
        /// </param>
        public Person(Contact contact)
        {
            this.Contact = contact;
        }

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.Contact.GetFirstNameProperty().Value;
            }

            set
            {
                this.Contact.GetFirstNameProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.Contact.GetLastNameProperty().Value;
            }

            set
            {
                this.Contact.GetLastNameProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the title of the person.
        /// </summary>
        public string Title
        {
            get
            {
                return this.Contact.GetTitleProperty().Value;
            }

            set
            {
                this.Contact.GetTitleProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the office address of the company.
        /// </summary>
        public string Address
        {
            get
            {
                return this.Contact.GetOfficeAddressProperty().Value;
            }

            set
            {
                this.Contact.GetOfficeAddressProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the work email of the company.
        /// </summary>
        public string Email
        {
            get
            {
                return this.Contact.GetWorkEmailProperty().Value;
            }

            set
            {
                this.Contact.GetWorkEmailProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the Phone of the person
        /// </summary>
        public string Phone
        {
            get
            {
                return this.Contact.GetWorkPhoneProperty().Value;
            }

            set
            {
                this.Contact.GetWorkPhoneProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the website of the person
        /// </summary>
        public string Website
        {
            get
            {
                return this.Contact.GetWebsiteProperty().Value;
            }

            set
            {
                this.Contact.GetWebsiteProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the company of the person
        /// </summary>
        public string CompanyName
        {
            get
            {
                return this.Contact.GetCompanyProperty().Value;
            }

            set
            {
                this.Contact.GetCompanyProperty().Value = value;
            }
        }

        /// <summary>
        /// Gets the tags on the contact. A tag name should start with an alphabet and can not contain special characters other than underscore and space.
        /// </summary>
        public List<string> Tags
        {
            get
            {
                return this.Contact.Tags;
            }

            private set
            {
                this.Contact.Tags = value;
            }
        }

        /// <summary>
        /// Gets or sets the star value of the contact. Rating of contact (Max value 5). This is not applicable for companies.
        /// </summary>
        public short StarValue
        {
            get
            {
                return this.Contact.StarValue;
            }

            set
            {
                if (value > 5)
                {
                    throw new ArgumentException("value");
                }

                if (this.Contact.Type == ContactType.Company)
                {
                    throw new ArgumentException("Star value is not applicable to companies.");
                }

                this.Contact.StarValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the lead score of the contact.
        /// </summary>
        public int LeadScore
        {
            get
            {
                return this.Contact.LeadScore;
            }

            set
            {
                this.Contact.LeadScore = value;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="Contact"/> associated with this <see cref="Person"/>
        /// </summary>
        public Contact Contact
        {
            get;
            set;
        }

        /// <summary>
        /// Get a list of persons from the <c>CRM</c>
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance.
        /// </param>
        /// <param name="maxPersons">
        /// The maximum number of persons to receive.
        /// </param>
        /// <returns>
        /// A list of persons.
        /// </returns>
        public static async Task<List<Person>> GetPersonsAsync(AgileCRM crm, int maxPersons)
        {
            var response = await crm.RequestAsync($"contacts/?page_size={maxPersons}", HttpMethod.Get, null).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<List<Contact>>(response).Select<Contact, Person>(c => new Person(c)).ToList();
        }

        /// <summary>
        /// Get a list of persons from the <c>CRM</c>
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance.
        /// </param>
        /// <param name="maxPersons">
        /// The maximum number of persons to receive.
        /// </param>
        /// <param name="cursor">
        /// Points to the first person of the list (used for paging).
        /// </param>
        /// <returns>
        /// A list of persons.
        /// </returns>
        public static async Task<List<Person>> GetPersonsAsync(AgileCRM crm, int maxPersons, string cursor)
        {
            var response = await crm.RequestAsync($"contacts/?page_size={maxPersons}&cursor={cursor}", HttpMethod.Get, null).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<List<Contact>>(response).Select<Contact, Person>(c => new Person(c)).ToList();
        }

        /// <summary>
        /// Removes tags from the person
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance.
        /// </param>
        /// <param name="tags">
        /// The tags to be removed
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public async Task RemoveTagsAsync(AgileCRM crm, List<string> tags)
        {
            await this.PullAsync(crm).ConfigureAwait(false);

            var updateTagsRequest = new UpdateContactTagsRequest(this.Contact, tags);
            var response = await crm.RequestAsync("contacts/delete/tags", HttpMethod.Put, JsonConvert.SerializeObject(updateTagsRequest)).ConfigureAwait(false);
            await this.PullAsync(crm).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds tags to the person
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance.
        /// </param>
        /// <param name="tags">
        /// The tags to be added
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public async Task AddTagsAsync(AgileCRM crm, List<string> tags)
        {
            await this.PullAsync(crm).ConfigureAwait(false);

            var updateTagsRequest = new UpdateContactTagsRequest(this.Contact, tags);
            var response = await crm.RequestAsync("contacts/edit/tags", HttpMethod.Put, JsonConvert.SerializeObject(updateTagsRequest)).ConfigureAwait(false);
            var updatedContact = JsonConvert.DeserializeObject<Contact>(response);
            this.Tags = updatedContact.Tags;
        }

        /// <summary>
        /// Checks whether the person exists in the <c>CRM</c>
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance.
        /// </param>
        /// <returns>
        /// Condition whether the person exists in the <c>CRM</c>
        /// </returns>
        public async Task<bool> ExistsAsync(AgileCRM crm)
        {
            if (this.Contact.Id != 0)
            {
                var response = await crm.RequestAsync($"contacts/{this.Contact.Id}", HttpMethod.Get, null).ConfigureAwait(false);

                if (!string.IsNullOrEmpty(response))
                {
                    return true;
                }
            }

            if (this.Contact.Id == 0 && !string.IsNullOrEmpty(this.Email))
            {
                var response = await crm.RequestAsync($"contacts/search/email/{this.Email}", HttpMethod.Get, null).ConfigureAwait(false);

                if (!string.IsNullOrEmpty(response))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Delete this person.
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public async Task DeletePersonAsync(AgileCRM crm)
        {
            if (this.Contact.Id == 0)
            {
                await this.PullAsync(crm).ConfigureAwait(false);
            }

            if (this.Contact.Id == 0)
            {
                throw new InvalidOperationException("The person identifier is not defined.");
            }

            await crm.RequestAsync($"contacts/{this.Contact.Id}", HttpMethod.Delete, null).ConfigureAwait(false);
            this.Contact.DisconnectFromCRM();
        }

        /// <summary>
        /// Pushes the information to the <c>crm</c>
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public async Task PushAsync(AgileCRM crm)
        {
            var exists = await this.ExistsAsync(crm).ConfigureAwait(false);
            if (!exists)
            {
                var newPersonRequest = new NewPersonRequest(this);
                var updatedContact = await crm.RequestAsync("contacts", HttpMethod.Post, JsonConvert.SerializeObject(newPersonRequest)).ConfigureAwait(false);
                this.Contact.Update(JsonConvert.DeserializeObject<Contact>(updatedContact));
            }
            else
            {
                // make sure the contact id is initialized
                if (this.Contact.Id == 0)
                {
                    var person = new Person(this.Email);
                    await person.PullAsync(crm).ConfigureAwait(false);
                    this.Contact.Id = person.Contact.Id;
                }

                // update properties
                var updatePropertiesRequest = new UpdateContactPropertiesRequest(this.Contact);
                await crm.RequestAsync("contacts/edit-properties", HttpMethod.Put, JsonConvert.SerializeObject(updatePropertiesRequest)).ConfigureAwait(false);

                // update lead score
                var updateLeadScoreRequest = new UpdateLeadScoreRequest(this.Contact);
                await crm.RequestAsync("contacts/edit/lead-score", HttpMethod.Put, JsonConvert.SerializeObject(updateLeadScoreRequest)).ConfigureAwait(false);

                // update star value
                var updateStarValueRequest = new UpdateStarValueRequest(this.Contact);
                await crm.RequestAsync("contacts/edit/add-star", HttpMethod.Put, JsonConvert.SerializeObject(updateStarValueRequest)).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Pulls the information from the <c>crm</c>
        /// </summary>
        /// <param name="crm">
        /// The <see cref="AgileCRM"/> instance
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> representing the read operation.
        /// </returns>
        public async Task<bool> PullAsync(AgileCRM crm)
        {
            if (this.Contact.Id != 0)
            {
                var response = await crm.RequestAsync($"contacts/{this.Contact.Id}", HttpMethod.Get, null).ConfigureAwait(false);

                if (!string.IsNullOrEmpty(response))
                {
                    this.Contact.Update(JsonConvert.DeserializeObject<Contact>(response));
                }
            }

            if (this.Contact.Id == 0 && !string.IsNullOrEmpty(this.Email))
            {
                var response = await crm.RequestAsync($"contacts/search/email/{this.Email}", HttpMethod.Get, null).ConfigureAwait(false);
                if (!string.IsNullOrEmpty(response))
                {
                    this.Contact.Update(JsonConvert.DeserializeObject<Contact>(response));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
