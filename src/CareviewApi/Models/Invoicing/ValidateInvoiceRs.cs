using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class ValidateInvoiceRs
    {
        public bool Success { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal Remaining { get; set; }
        public string Message { get; set; }
    }
}
