using CareviewApi.Helpers;
using CareviewApi.Models.Clients;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CareviewApi
{
    public class Clients
    {
        private readonly CareviewApiConnection _connection;

        public Clients(CareviewApiConnection connection)
        {
            _connection = connection;
        }

        public async Task<GetRs> Get(string ndisNumber)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.GetContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/get/{ndisNumber}?subscription-key={_connection.SubscriptionKey}");
            return JsonConvert.DeserializeObject<GetRs>(content);
        }
    }
}
