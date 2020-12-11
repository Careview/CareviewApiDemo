using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Clients
{
    public class GetClientNotesRq
    {
        public int PageNumber { get; set; }
        public string ClientNdisNumber { get; set; }
    }
}
