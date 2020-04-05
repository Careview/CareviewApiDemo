using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Lookup
{
    public class GetSupportCategoriesRs
    {
        public bool Success { get; set; }
        public List<SupportCategory> Result { get; set; }
        public string Message { get; set; }
    }
}
