using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Clients
{
    public class GetClientTasksRs : BaseRs
    {
        public PaginatedResult<ClientTask> Tasks { get; set; }
    }
}
