using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Lookup
{
    public class GetSupportCategoriesRs : BaseRs
    {
        public List<SupportCategory> Result { get; set; }
    }
}
