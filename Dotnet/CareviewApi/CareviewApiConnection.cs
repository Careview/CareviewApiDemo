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
        public readonly string ApiKey;

        public CareviewApiConnection(
            string subscriptionKey,
            string apiKey,
            bool testMode)
        {
            SubscriptionKey = subscriptionKey;
            ApiKey = apiKey;

            BaseUrl = testMode
                ? $"https://careview.azure-api.net/test"
                : $"https://careview.azure-api.net";

            HttpClient = new HttpClient();
        }

        public HttpClient HttpClient { get; }
    }
}
