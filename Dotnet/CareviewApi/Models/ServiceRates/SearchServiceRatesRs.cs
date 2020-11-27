using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.ServiceRates
{
    public class SearchServiceRatesRs
    {
        public bool Success { get; set; }
        public Service ServiceRate { get; set; }
        public string Message { get; set; }
    }
}
