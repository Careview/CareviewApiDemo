using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Invoicing
{
    public class AttachToInvoiceRs : BaseRs
    {
        public InvoiceHeader Header { get; set; }
        public string Filename { get; set; }
    }
}
