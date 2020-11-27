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

        public async Task<GetClientRs> Get(string ndisNumber)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.GetContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/get/{ndisNumber}?subscription-key={_connection.SubscriptionKey}");
            return JsonConvert.DeserializeObject<GetClientRs>(content);
        }

        public async Task<SearchClientRs> Search(string search)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/search?subscription-key={_connection.SubscriptionKey}",
                new
                {
                    Term = search
                });
            return JsonConvert.DeserializeObject<SearchClientRs>(content);
        }

        public async Task<CreateClientRs> Create(CreateClientRq data)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/create?subscription-key={_connection.SubscriptionKey}",
                data);
            return JsonConvert.DeserializeObject<CreateClientRs>(content);
        }
    }
}
