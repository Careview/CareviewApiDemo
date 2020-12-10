using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Clients
{
    public class CreateClientRs : BaseRs
    {
        public Client Client { get; set; }
        public List<Client> RelatedClients { get; set; } = new List<Client>();
    }
}
