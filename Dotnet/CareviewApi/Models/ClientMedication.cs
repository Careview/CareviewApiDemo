using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ClientMedication
    {
        public string PrescribedBy { get; set; }
        public string PrescribedDosage { get; set; }
        public string MedicationDetails { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string LastAdministeredBy { get; set; }
        public DateTime? LastAdministeredDate { get; set; }
        public string Medication { get; set; }
    }
}
