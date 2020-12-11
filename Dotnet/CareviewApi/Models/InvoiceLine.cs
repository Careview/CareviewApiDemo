using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class InvoiceLine
    {
        public string ClaimType { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public string PlanCategoryId { get; set; }
        public string SupportItemNumber { get; set; }
        public decimal Quantity { get; set; }
        public string GstCode { get; set; }
        public decimal Gst { get; set; }
        public decimal Rate { get; set; }
    }
}
