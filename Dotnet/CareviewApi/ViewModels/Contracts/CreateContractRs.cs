using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Contracts
{
    public class CreateContractRs : BaseRs
    {
        public Contract Contract { get; set; }
    }
}
