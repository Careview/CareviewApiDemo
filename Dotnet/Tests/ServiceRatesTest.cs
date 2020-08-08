using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ServiceRatesTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        private ServiceRates GetApiClient()
        {
            return new ServiceRates(ApiClient.Get());
        }

        [Test]
        public async Task TestSearch()
        {
            var api = GetApiClient();

            var rs = await api.Search("07_002_0106_8_3");

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.ServiceRate != null);
        }
    }
}
