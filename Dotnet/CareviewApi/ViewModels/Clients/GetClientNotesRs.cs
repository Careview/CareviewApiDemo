using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Clients
{
    public class GetClientNotesRs : BaseRs
    {
        public PaginatedResult<ClientNote> Notes { get; set; }
    }
}
