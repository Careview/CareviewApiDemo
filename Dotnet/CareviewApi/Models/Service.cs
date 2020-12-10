using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class Service
    {
        public string Description { get; set; }
        public string SupportItem { get; set; }
        public string SupportItemNumber { get; set; }
        public SupportCategory SupportCategory { get; set; } = new SupportCategory();
        public List<ServiceRate> Rates { get; set; } = new List<ServiceRate>();
    }
}
