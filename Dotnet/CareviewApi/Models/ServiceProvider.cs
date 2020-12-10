using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ServiceProvider
    {
        public string Name { get; set; }
        public string BillingContact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ABN { get; set; }
        public string NDISRegistrationNumber { get; set; }
        public bool IsActive { get; set; }
        public string ProviderCode { get; set; }
    }
}
