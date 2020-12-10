using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class Client
    {
        public Guid Identifier { get; set; }
        public string NDISNumber { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public string Status { get; set; }
        public string ServiceRegion { get; set; }
        public string ReferredBy { get; set; }
        public string OtherDisability { get; set; }
        public bool ParticipantConsentsToEngagingInTheAuditingProcess { get; set; }
        public string AccountFile { get; set; }
        public string AccountCode { get; set; }
        public DateTime? ExitOrDeceasedDate { get; set; }
        public DateTime? PriceRise { get; set; }
    }
}
