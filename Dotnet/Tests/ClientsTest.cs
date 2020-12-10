using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ClientsTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        private Clients GetApiClient()
        {
            return new Clients(ApiClient.Get());
        }

        [Test]
        public async Task TestGetClient()
        {
            var api = GetApiClient();

            var ndisNumber = "123456789";
            var rs = await api.Get(ndisNumber);
            
            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.AreEqual(ndisNumber, rs.Client.NDISNumber);
        }

        [Test]
        public async Task TestSearchClient()
        {
            var api = GetApiClient();

            var rs = await api.Search("123456789");

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Clients.Any());
        }

        [Test]
        public async Task TestGetMedicalHistory()
        {
            var api = GetApiClient();

            var rs = await api.GetMedicalHistory(new CareviewApi.ViewModels.Clients.GetClientMedicalHistoryRq() { ClientNdisNumber = "123456789", PageNumber = 1 });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.MedicalHistory.TotalItems > 0);
            Assert.IsTrue(rs.MedicalHistory.Result.Any());
        }

        [Test]
        public async Task TestGetNotes()
        {
            var api = GetApiClient();

            var rs = await api.GetNotes(new CareviewApi.ViewModels.Clients.GetClientNotesRq() { ClientNdisNumber = "123456789", PageNumber = 1 });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Notes.TotalItems > 0);
            Assert.IsTrue(rs.Notes.Result.Any());
        }

        [Test]
        public async Task TestGetTasks()
        {
            var api = GetApiClient();

            var rs = await api.GetTasks(new CareviewApi.ViewModels.Clients.GetClientTasksRq() { ClientNdisNumber = "123456789", PageNumber = 1 });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Tasks.TotalItems > 0);
            Assert.IsTrue(rs.Tasks.Result.Any());
        }

        [Test]
        public async Task TestCreateClient()
        {
            var api = GetApiClient();

            var ndisNumber = "123456789";
            var rs = await api.Create(new CareviewApi.ViewModels.Clients.CreateClientRq()
            {
                NDISNumber = ndisNumber,
                Email = "testparticipant@test.com",
                Title = "Mr",
                FirstName = "Test",
                LastName = "Participant",
                Gender = "Other",
                DateOfBirth = new DateTime(1980, 01, 01),
                Phone = "0732123456",
                Mobile = "0404123456",
                ServiceRegion = "Brisbane",

                PrimaryDisabilities = new List<string>() { "Alzheimer" },

                IsPlanManagementClient = true,

                Address1 = "123 Main Street",
                Suburb = "Green Hills",
                City = "Test Ville",
                PostCode = "4321",

                RelatedClients = new List<CareviewApi.Models.ClientRelationship>()
                {
                    new CareviewApi.Models.ClientRelationship()
                    {
                        RelationshipType = "Mother",
                        IsPrimaryContact = true,
                        IsEmergencyContact = true,
                        Title = "Ms",
                        FirstName = "Mother Of",
                        LastName = "Participant",
                        Phone = "0732123456",
                        Email = "testparticipantmother@test.com",
                    }
                }
            });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.AreEqual(ndisNumber, rs.Client.NDISNumber);
            Assert.AreEqual(1, rs.RelatedClients.Count);
            Assert.AreEqual("Mother Of", rs.RelatedClients.First().FirstName);
        }
    }
}
