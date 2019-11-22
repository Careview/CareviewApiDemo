using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CareviewApi
{
    public class CareviewApiConnection
    {
        public string BaseUrl { get; set; }
        public readonly string SubscriptionKey;
        public readonly string OrganisationKey;

        public CareviewApiConnection(
            string subscriptionKey,
            string organisationKey,
            bool testMode)
        {
            SubscriptionKey = subscriptionKey;
            OrganisationKey = organisationKey;

            BaseUrl = testMode
                ? $"https://careview.azure-api.net/test"
                : $"https://careview.azure-api.net";

            HttpClient = new HttpClient();
        }

        public HttpClient HttpClient { get; }
    }
}
