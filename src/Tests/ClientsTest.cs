using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
    }
}
