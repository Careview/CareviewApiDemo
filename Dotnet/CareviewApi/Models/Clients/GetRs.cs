using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Clients
{
    public class GetRs
    {
        public bool Success { get; set; }
        public Client Client { get; set; }
        public string Message { get; set; }
    }
}
