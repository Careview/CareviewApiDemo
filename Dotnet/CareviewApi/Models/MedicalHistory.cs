using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class MedicalHistory
    {
        public Guid Identifier { get; set; }
        public string Notes { get; set; }
        public string RecordType { get; set; }
        public DateTime Date { get; set; }
    }
}
