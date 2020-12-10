using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class GetInvoiceRs : BaseRs
    {
        public InvoiceHeader Header { get; set; }
        public List<InvoiceLine> Lines { get; set; }
    }
}
