using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class InvoiceHeader
    {
        public string Reference { get; set; }
        public string CustomReferenceName { get; set; }
        public string CustomReferenceValue { get; set; }
        public DateTime DateCreated { get; set; }
        public string ProviderInvoiceNumber { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientNDISNumber { get; set; }
    }
}
