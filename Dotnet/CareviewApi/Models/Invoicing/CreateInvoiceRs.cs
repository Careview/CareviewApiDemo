using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class CreateInvoiceRs
    {
        public bool Success { get; set; }
        public InvoiceHeader Header { get; set; }
        public List<InvoiceLine> Lines { get; set; }
        public string Message { get; set; }
    }
}
