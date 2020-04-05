using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Lookup
{
    public class GetGstCodesRs
    {
        public bool Success { get; set; }
        public List<string> Result { get; set; }
        public string Message { get; set; }
    }
}
