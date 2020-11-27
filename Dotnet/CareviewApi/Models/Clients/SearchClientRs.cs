using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Clients
{
    public class SearchClientRs
    {
        public bool Success { get; set; }
        public List<Client> Clients { get; set; }
        public string Message { get; set; }
    }
}
