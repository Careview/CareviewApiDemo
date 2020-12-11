using CareviewApi.Helpers;
using CareviewApi.ViewModels.Contracts;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CareviewApi
{
    public class Contracts
    {
        private readonly CareviewApiConnection _connection;

        public Contracts(CareviewApiConnection connection)
        {
            _connection = connection;
        }

        public async Task<CreateContractRs> Create(CreateContractRq data)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/contracts/create?subscription-key={_connection.SubscriptionKey}",
                data);
            return JsonConvert.DeserializeObject<CreateContractRs>(content);
        }
    }
}
