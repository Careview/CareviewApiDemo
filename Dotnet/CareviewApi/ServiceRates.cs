using CareviewApi.Helpers;
using CareviewApi.Models.ServiceRates;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CareviewApi
{
    public class ServiceRates
    {
        private readonly CareviewApiConnection _connection;

        public ServiceRates(CareviewApiConnection connection)
        {
            _connection = connection;
        }

        public async Task<SearchRs> Search(string search)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/servicerates/search?subscription-key={_connection.SubscriptionKey}",
                new
                {
                    Term = search
                });
            return JsonConvert.DeserializeObject<SearchRs>(content);
        }
    }
}
