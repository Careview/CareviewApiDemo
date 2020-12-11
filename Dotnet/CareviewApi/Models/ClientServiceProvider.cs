using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ClientServiceProvider
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal ServiceHours { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
