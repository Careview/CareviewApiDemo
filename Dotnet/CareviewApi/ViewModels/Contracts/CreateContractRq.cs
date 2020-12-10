using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Contracts
{
    public class CreateContractRq
    {
        public string ClientNDISNumber { get; set; }
        public string ContractNumber { get; set; }
        public string FundingSource { get; set; }
        public string FundingManagement { get; set; }
        public decimal TotalFundingAmount { get; set; }
        public DateTime NDISPlanStartDate { get; set; }
        public DateTime NDISPlanEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReferralDate { get; set; }
        public DateTime SignedDate { get; set; }
        public string Notes { get; set; }
    }
}
