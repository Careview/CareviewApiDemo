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
        public async Task TestCreateClient()
        {
            var api = GetApiClient();

            var ndisNumber = "123456788";
            var rs = await api.Create(new CareviewApi.Models.Clients.CreateClientRq()
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

                RelatedClients = new List<CareviewApi.Models.Clients.CreateClientRelationship>()
                {
                    new CareviewApi.Models.Clients.CreateClientRelationship()
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
