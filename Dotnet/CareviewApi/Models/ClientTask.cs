using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ClientTask
    {
        public Guid Identifier { get; set; }
        public string Task { get; set; }
        public string Category { get; set; }
        public string AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
