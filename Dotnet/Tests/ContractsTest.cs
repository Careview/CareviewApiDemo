using CareviewApi;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ContractsTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Clear()
        {
        }

        private Contracts GetApiClient()
        {
            return new Contracts(ApiClient.Get());
        }

        [Test]
        public async Task TestCreateContract()
        {
            var api = GetApiClient();

            var rs = await api.Create(new CareviewApi.ViewModels.Contracts.CreateContractRq()
            {
                ClientNDISNumber = "123456789",
                FundingSource = "NDIS",
                FundingManagement = "Registered Plan Management Provider",
                ContractNumber = "120896106",
                NDISPlanStartDate = DateTime.Today.AddDays(-30),
                NDISPlanEndDate = DateTime.Today.AddDays(300),
                StartDate = DateTime.Today.AddDays(-30),
                EndDate = DateTime.Today.AddDays(300),
                ReferralDate = DateTime.Today.AddDays(-30),
                SignedDate = DateTime.Today.AddDays(-30),
                TotalFundingAmount = 250000,
                Notes = "Test created by API"
            });

            Assert.IsTrue(rs.Success);
            Assert.IsNull(rs.Message);
            Assert.AreEqual("120896106", rs.Contract.ContractNumber);
        }
    }
}
