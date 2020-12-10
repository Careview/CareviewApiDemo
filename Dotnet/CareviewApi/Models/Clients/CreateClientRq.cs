using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Clients
{
    public class CreateClientRq
    {
        public string NDISNumber { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string ServiceRegion { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public DateTime? AgreementSignedDate { get; set; }
        public decimal? PlanManagementCurrentRate { get; set; }

        public bool IsAboriginal { get; set; }
        public bool IsTorresStraitIslander { get; set; }

        public List<string> PrimaryDisabilities { get; set; }

        public bool IsPlanManagementClient { get; set; }
        public bool IsSupportCoordinationClient { get; set; }
        public bool IsServiceProviderClient { get; set; }

        public bool MonthlyStatementOptOut { get; set; }
        public bool AllInvoicesAutoApproved { get; set; }
        public bool IsPostalStatementRequired { get; set; }
        public bool EnglishIsPrimaryLanguage { get; set; }
        public bool InterpreterRequired { get; set; }

        public string OtherPrimaryLanguage { get; set; }
        public string CulturalRequirements { get; set; }
        public string Allergies { get; set; }
        public string LivingArrangements { get; set; }
        public string Interests { get; set; }
        public string Notes { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }

        public List<ClientRelationship> RelatedClients { get; set; } = new List<ClientRelationship>();
    }
}
