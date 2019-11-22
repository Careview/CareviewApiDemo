using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ValidateInvoiceTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        [Test]
        public async Task TestValidOrgWithValidNdisNumber()
        {
            var subscriptionKey = "";
            var organisationKey = "";
            var testMode = true;

            var connection = new CareviewApiConnection(
                subscriptionKey,
                organisationKey,
                testMode);

            var invoicing = new Invoicing(connection);
            var rs = await invoicing.ValidateAsync(new CareviewApi.Models.ValidateInvoiceRq()
            {
                ClientNdisNumber = "",
                InvoiceLines = new List<CareviewApi.Models.ValidateInvoiceLine>()
                {
                    new CareviewApi.Models.ValidateInvoiceLine()
                    {
                        DeliveredDate = new DateTime(2019, 11, 20), SupportItemNumber = "01_002_0107_1_1", GstCode = "P2", Quantity = 1, Rate = 55,
                    }
                },
            });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
        }
    }
}
