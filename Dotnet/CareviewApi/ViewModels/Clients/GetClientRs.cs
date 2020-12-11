using CareviewApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.ViewModels.Clients
{
    public class GetClientRs : BaseRs
    {
        public Client Client { get; set; }
        public List<Contract> Contracts { get; set; } = new List<Contract>();
        public List<ClientRelationship> RelatedClients { get; set; } = new List<ClientRelationship>();
        public List<ClientMedication> Medications { get; set; } = new List<ClientMedication>();
        public List<ClientServiceProvider> ServiceProviders { get; set; } = new List<ClientServiceProvider>();
        public List<ClientGoal> Goals { get; set; } = new List<ClientGoal>();
        public List<ClientAlert> Alerts { get; set; } = new List<ClientAlert>();
    }
}
