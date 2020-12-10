using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Lookup
{
    public class GetServiceProvidersRs : BaseRs
    {
        public List<ServiceProvider> Result { get; set; }
    }
}
