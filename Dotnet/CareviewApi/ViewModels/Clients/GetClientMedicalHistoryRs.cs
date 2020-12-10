using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Clients
{
    public class GetClientMedicalHistoryRs : BaseRs
    {
        public PaginatedResult<MedicalHistory> MedicalHistory { get; set; }
    }
}
