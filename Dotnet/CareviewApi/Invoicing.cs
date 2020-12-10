using CareviewApi.Helpers;
using CareviewApi.ViewModels.Invoicing;
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

        public async Task<ValidateInvoiceRs> ValidateAsync(ValidateInvoiceRq rq)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/invoicing/validate?subscription-key={_connection.SubscriptionKey}",
                rq);
            return JsonConvert.DeserializeObject<ValidateInvoiceRs>(content);
        }

        public async Task<CreateInvoiceRs> CreateAsync(CreateInvoiceRq rq)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/invoicing/create?subscription-key={_connection.SubscriptionKey}",
                rq);
            return JsonConvert.DeserializeObject<CreateInvoiceRs>(content);
        }

        public async Task<AttachToInvoiceRs> AttachAsync(AttachToInvoiceRq rq)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/invoicing/attach?subscription-key={_connection.SubscriptionKey}",
                rq);
            return JsonConvert.DeserializeObject<AttachToInvoiceRs>(content);
        }

        public async Task<GetInvoiceRs> GetAsync(string reference)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.GetContentAsync(
                _connection,
                $"{_connection.BaseUrl}/invoicing/get/{reference}?subscription-key={_connection.SubscriptionKey}");
            return JsonConvert.DeserializeObject<GetInvoiceRs>(content);
        }
    }
}
