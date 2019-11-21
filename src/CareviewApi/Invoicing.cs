using CareviewApi.Helpers;
using CareviewApi.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CareviewApi
{
    public class Invoicing
    {
        private readonly CareviewApiConnection _connection;

        public Invoicing(CareviewApiConnection connection)
        {
            _connection = connection;
        }

        public async Task<ValidateInvoiceRs> Validate(ValidateInvoiceRq rq)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("OrganisationKey", _connection.OrganisationKey);
                var content = await HttpGet.PostContentAsync(
                    client,
                    $"{_connection.BaseUrl}/invoicing/validate?subscription-key={_connection.SubscriptionKey}",
                    rq);
                return JsonConvert.DeserializeObject<ValidateInvoiceRs>(content);
            }
        }
    }
}
