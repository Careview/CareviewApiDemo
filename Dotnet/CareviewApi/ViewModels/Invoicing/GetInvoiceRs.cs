﻿using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Invoicing
{
    public class GetInvoiceRs : BaseRs
    {
        public InvoiceHeader Header { get; set; }
        public List<InvoiceLine> Lines { get; set; }
    }
}
