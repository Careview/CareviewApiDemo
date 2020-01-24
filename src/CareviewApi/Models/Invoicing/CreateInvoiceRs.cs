using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class CreateInvoiceRs
    {
        public bool Success { get; set; }
        public string InvoiceReference { get; set; }
        public string Message { get; set; }
    }
}
