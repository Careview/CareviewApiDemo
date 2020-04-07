using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class AttachToInvoiceRs
    {
        public bool Success { get; set; }
        public InvoiceHeader Header { get; set; }
        public string Filename { get; set; }
        public string Message { get; set; }
    }
}
