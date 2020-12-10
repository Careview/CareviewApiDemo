using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Invoicing
{
    public class ValidateInvoiceRs : BaseRs
    {
        public decimal TotalCharge { get; set; }
        public decimal Remaining { get; set; }
    }
}
