// <copyright file="AgileCRM.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace AgileAPI
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class used to interact with the agile CRM
    /// </summary>
    public class AgileCRM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgileCRM"/> class.
        /// </summary>
        /// <param name="domain">
        /// The domain to be used,
        /// </param>
        /// <param name="email">
        /// The email to be used
        /// </param>
        /// <param name="apiKey">
        /// The API key to be used
        /// </param>
        public AgileCRM(string domain, string email, string apiKey)
        {
            this.ApiKey = apiKey;
            this.Domain = domain;
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets the agileCRM domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the agileCRM email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the <c>agileCRM</c>> API key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets the domain url
        /// </summary>
        public string DomainUrl
        {
            get
            {
                return $"https://{this.Domain}.agilecrm.com/dev/api/";
            }
        }

        /// <summary>
        /// Gets the full URL for the given route
        /// </summary>
        /// <param name="route">
        /// The route
        /// </param>
        /// <returns>
        /// The full URL for the given route
        /// </returns>
        public string GetUrl(string route)
        {
            return this.DomainUrl + route;
        }

        /// <summary>
        /// Executes the given request.
        /// </summary>
        /// <param name="route">
        /// The route
        /// </param>
        /// <param name="method">
        /// The method to be executed
        /// </param>
        /// <param name="data">
        /// The data to be used
        /// </param>
        /// <returns>
        /// The result of the request
        /// </returns>
        internal async Task<string> RequestAsync(string route, HttpMethod method, string data)
        {
            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{this.Email}:{this.ApiKey}")));

            using (var client = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = authValue },
            })
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var request = new HttpRequestMessage(method, new Uri(this.GetUrl(route)));
                request.Method = method;
                if (!string.IsNullOrEmpty(data))
                {
                    request.Content = new StringContent(data, Encoding.GetEncoding("ISO-8859-1"), "application/json");
                }

                var response = await client.SendAsync(request).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
    }
}
