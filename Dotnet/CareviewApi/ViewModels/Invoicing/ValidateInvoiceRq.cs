using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Invoicing
{
    public class ValidateInvoiceRq
    {
        public string ClientNdisNumber { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; }
    }
}
