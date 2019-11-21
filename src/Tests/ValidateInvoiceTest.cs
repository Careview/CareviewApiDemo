﻿using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Logic
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
            var clientNdisNumber = "";

            var connection = new CareviewApiConnection(
                subscriptionKey,
                organisationKey,
                true);
            var invoicing = new Invoicing(connection);
            var rs = await invoicing.Validate(new CareviewApi.Models.ValidateInvoiceRq()
            {
                ClientNdisNumber = clientNdisNumber,
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