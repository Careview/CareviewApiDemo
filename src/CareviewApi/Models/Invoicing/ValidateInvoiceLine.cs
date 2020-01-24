using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class ValidateInvoiceLine
    {
        public DateTime DeliveredDate { get; set; }
        public string SupportItemNumber { get; set; }
        public string GstCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}
