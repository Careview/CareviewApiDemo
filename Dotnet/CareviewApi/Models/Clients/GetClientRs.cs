using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Clients
{
    public class GetClientRs
    {
        public bool Success { get; set; }
        public Client Client { get; set; }
        public List<Contract> Contracts { get; set; } = new List<Contract>();
        public string Message { get; set; }
    }
}
