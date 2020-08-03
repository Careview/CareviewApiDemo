using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class LookupTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        private Lookup GetApiClient()
        {
            return new Lookup(ApiClient.Get());
        }

        [Test]
        public async Task TestGetGstCodes()
        {
            var api = GetApiClient();

            var rs = await api.GetGstCodes();
            
            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Result.Any());
        }

        [Test]
        public async Task TestGetInvoiceClaimTypes()
        {
            var api = GetApiClient();

            var rs = await api.GetInvoiceClaimTypes();

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Result.Any());
        }

        [Test]
        public async Task TestGetSupportCategories()
        {
            var api = GetApiClient();

            var rs = await api.GetSupportCategories();

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Result.Any());
        }

        [Test]
        public async Task TestGetServiceProviders()
        {
            var api = GetApiClient();

            var rs = await api.GetServiceProviders();

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsTrue(rs.Result.Any());
        }
    }
}
