using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class Contract
    {
        public string Reference { get; set; }
        public string ContractNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? NDISPlanStartDate { get; set; }
        public DateTime? NDISPlanEndDate { get; set; }
        public string Notes { get; set; }
        public decimal TotalFunding { get; set; }
        public decimal TotalAllocated { get; set; }
        public decimal TotalRemaining { get; set; }
        public decimal TotalDelivered { get; set; }
        public decimal TotalClaimed { get; set; }
        public decimal TotalUnclaimed { get; set; }
        public string Status { get; set; }
        public List<PlanBudget> PlanBudgets { get; set; } = new List<PlanBudget>();
    }
}
