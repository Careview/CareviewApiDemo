using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Lookup
{
    public class GetServiceProvidersRs : BaseRs
    {
        public List<ServiceProvider> Result { get; set; }
    }
}
