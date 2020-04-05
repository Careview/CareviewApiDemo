using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class CreateInvoiceRq
    {
        public string ClientNdisNumber { get; set; }
        public string ServiceProviderAbn { get; set; }
        public string ProviderInvoiceNumber { get; set; }
        public DateTime ProviderInvoiceDate { get; set; }
        public bool ApprovedByClient { get; set; }
        public string Notes { get; set; }
        public string CustomReferenceName { get; set; }
        public string CustomReferenceValue { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; }
    }
}
