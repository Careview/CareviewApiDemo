using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Lookup
{
    public class GetServiceProvidersRs
    {
        public bool Success { get; set; }
        public List<ServiceProvider> Result { get; set; }
        public string Message { get; set; }
    }
}
