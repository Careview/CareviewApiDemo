using CareviewApi.Helpers;
using CareviewApi.ViewModels.Clients;
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

        public async Task<GetClientMedicalHistoryRs> GetMedicalHistory(GetClientMedicalHistoryRq rq)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/medical-history?subscription-key={_connection.SubscriptionKey}",
                rq);
            return JsonConvert.DeserializeObject<GetClientMedicalHistoryRs>(content);
        }

        public async Task<GetClientNotesRs> GetNotes(GetClientNotesRq rq)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/notes?subscription-key={_connection.SubscriptionKey}",
                rq);
            return JsonConvert.DeserializeObject<GetClientNotesRs>(content);
        }

        public async Task<GetClientTasksRs> GetTasks(GetClientTasksRq rq)
        {
            Http.AddAuthHeader(_connection);
            var content = await Http.PostContentAsync(
                _connection,
                $"{_connection.BaseUrl}/clients/tasks?subscription-key={_connection.SubscriptionKey}",
                rq);
            return JsonConvert.DeserializeObject<GetClientTasksRs>(content);
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
