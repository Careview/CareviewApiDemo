using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Clients
{
    public class ClientAlert
    {
        public string AlertText { get; set; }
        public string Status { get; set; }
        public bool ShowInClientProfile { get; set; }
        public bool ShowInClientCoordination { get; set; }
        public bool ShowInServiceContract { get; set; }
        public bool ShowInInvoiceCreation { get; set; }
    }
}
