using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Clients
{
    public class PlanBudget
    {
        public string CategoryId { get; set; }
        public string Category { get; set; }
        public string Group { get; set; }
        public decimal Budget { get; set; }
        public decimal Unallocated { get; set; }
        public decimal Delivered { get; set; }
        public decimal Remaining { get; set; }
    }
}
