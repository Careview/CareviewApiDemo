using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ClientRelationship
    {
        public string RelationshipType { get; set; }
        public bool IsPrimaryContact { get; set; }
        public bool IsEmergencyContact { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
