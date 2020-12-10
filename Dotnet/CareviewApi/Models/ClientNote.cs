using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ClientNote
    {
        public Guid Identifier { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
    }
}
