using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class CreateInvoiceLine
    {
        public string Type { get; set; }
        public string GstCode { get; set; }
        public DateTime DeliveredDate { get; set; }
        public string PlanCategoryId { get; set; }
        public string SupportItemNumber { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}
