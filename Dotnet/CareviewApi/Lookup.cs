using CareviewApi.Helpers;
using CareviewApi.Models.Lookup;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CareviewApi
{
    public class Lookup
    {
        private readonly CareviewApiConnection _connection;

        public Lookup(CareviewApiConnection connection)
        {
            _connection = connection;
        }

        public async Task<GetGstCodesRs> GetGstCodes()
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.GetContentAsync(
                _connection,
                $"{_connection.BaseUrl}/lookup/gstcodes?subscription-key={_connection.SubscriptionKey}");
            return JsonConvert.DeserializeObject<GetGstCodesRs>(content);
        }

        public async Task<GetInvoiceClaimTypesRs> GetInvoiceClaimTypes()
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.GetContentAsync(
                _connection,
                $"{_connection.BaseUrl}/lookup/invoiceclaimtypes?subscription-key={_connection.SubscriptionKey}");
            return JsonConvert.DeserializeObject<GetInvoiceClaimTypesRs>(content);
        }

        public async Task<GetSupportCategoriesRs> GetSupportCategories()
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.GetContentAsync(
                _connection,
                $"{_connection.BaseUrl}/lookup/supportcategories?subscription-key={_connection.SubscriptionKey}");
            return JsonConvert.DeserializeObject<GetSupportCategoriesRs>(content);
        }
    }
}
