using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class InvoiceTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        private Invoicing GetApiClient()
        {
            return new Invoicing(ApiClient.Get());
        }

        [Test]
        public async Task TestValidate()
        {
            var api = GetApiClient();

            var rs = await api.ValidateAsync(new CareviewApi.Models.Invoicing.ValidateInvoiceRq()
            {
                ClientNdisNumber = "123456789",
                InvoiceLines = new List<CareviewApi.Models.Invoicing.InvoiceLine>()
                {
                    new CareviewApi.Models.Invoicing.InvoiceLine()
                    {
                        DeliveredDate = new DateTime(2019, 11, 20),
                        SupportItemNumber = "01_002_0107_1_1",
                        GstCode = "P2",
                        Quantity = 1,
                        Rate = 55,
                    }
                },
            });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
        }

        [Test]
        public async Task TestCreate()
        {
            var api = GetApiClient();

            var rs = await api.CreateAsync(new CareviewApi.Models.Invoicing.CreateInvoiceRq()
            {
                ClientNdisNumber = "123456789",
                ServiceProviderAbn = "123456789",
                ProviderInvoiceNumber = "invtest-123",
                ProviderInvoiceDate = new DateTime(2019, 07, 03),
                ApprovedByClient = false,
                Notes = "test 123-456",
                InvoiceLines = new List<CareviewApi.Models.Invoicing.InvoiceLine>()
                {
                    new CareviewApi.Models.Invoicing.InvoiceLine()
                    {
                        Type = "STAND",
                        DeliveredDate = new DateTime(2019, 07, 03),
                        PlanCategoryId = "1",
                        SupportItemNumber = "01_002_0107_1_1",
                        GstCode = "P2",
                        Quantity = 1,
                        Rate = 55,
                    }
                },
            });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsNotNull(rs.InvoiceReference);
            Assert.AreNotEqual("", rs.InvoiceReference);
        }
    }
}
