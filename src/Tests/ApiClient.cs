using CareviewApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class ApiClient
    {
        public static CareviewApiConnection Get()
        {
            var subscriptionKey = "";
            var apiKey = "";
            var testMode = true;

            return new CareviewApiConnection(
                subscriptionKey,
                apiKey,
                testMode);
        }
    }
}
