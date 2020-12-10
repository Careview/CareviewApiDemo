using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
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

            var rs = await api.ValidateAsync(new CareviewApi.ViewModels.Invoicing.ValidateInvoiceRq()
            {
                ClientNdisNumber = "123456789",
                InvoiceLines = new List<CareviewApi.Models.InvoiceLine>()
                {
                    new CareviewApi.Models.InvoiceLine()
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
            Assert.IsTrue(rs.Remaining > 0);
            Assert.IsNull(rs.Message);
        }

        [Test]
        public async Task TestCreate()
        {
            var api = GetApiClient();

            var rs = await api.CreateAsync(new CareviewApi.ViewModels.Invoicing.CreateInvoiceRq()
            {
                ClientNdisNumber = "123456789",
                ServiceProviderAbn = "123456789",
                ProviderInvoiceNumber = "invtest-123",
                ProviderInvoiceDate = new DateTime(2019, 07, 03),
                ApprovedByClient = false,
                Notes = "test 123-456",
                CustomReferenceName = "OCR Batch Id",
                CustomReferenceValue = "OCR-0001",
                InvoiceLines = new List<CareviewApi.Models.InvoiceLine>()
                {
                    new CareviewApi.Models.InvoiceLine()
                    {
                        ClaimType = "STAND",
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
            Assert.IsNotNull(rs.Header);
            Assert.IsNotNull(rs.Lines);
            Assert.IsNotNull(rs.Header.Reference);
            Assert.AreNotEqual("", rs.Header.Reference);
            Assert.AreEqual("OCR Batch Id", rs.Header.CustomReferenceName);
            Assert.AreEqual("OCR-0001", rs.Header.CustomReferenceValue);
            Assert.AreEqual(1, rs.Lines.Count);
        }

        [Test]
        public async Task TestAttachFile()
        {
            var api = GetApiClient();

            var rs = await api.AttachAsync(new CareviewApi.ViewModels.Invoicing.AttachToInvoiceRq()
            {
                Reference = "123456789",
                Filename = "lolcats.jpg",
                AttachmentData = File.ReadAllBytes("C:\\Temp\\lolcats.jpg"),
            });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsNotNull(rs.Header);
            Assert.IsNotNull(rs.Header.Reference);
            Assert.AreNotEqual("", rs.Header.Reference);
            Assert.AreEqual("lolcats.jpg", rs.Filename);
        }

        [Test]
        public async Task TestGet()
        {
            var api = GetApiClient();

            var rs = await api.GetAsync("NDIS-000013789");

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.IsNotNull(rs.Header);
            Assert.IsNotNull(rs.Lines);
            Assert.AreEqual("NDIS-000013789", rs.Header.Reference);
            Assert.AreEqual("OCR Batch Id", rs.Header.CustomReferenceName);
            Assert.AreEqual("OCR-0001", rs.Header.CustomReferenceValue);
            Assert.AreEqual(1, rs.Lines.Count);
        }
    }
}
