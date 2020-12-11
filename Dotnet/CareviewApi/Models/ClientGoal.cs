using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ClientGoal
    {
        public string Goal { get; set; }
        public decimal PercentageComplete { get; set; }
        public string Status { get; set; }
        public DateTime ScStartDate { get; set; }
        public DateTime ScEndDate { get; set; }
        public double TimeCompleted { get; set; }
    }
}
