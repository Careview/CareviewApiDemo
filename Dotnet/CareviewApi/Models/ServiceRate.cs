using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models
{
    public class ServiceRate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Amount { get; set; }
        public string PriceGuide { get; set; }
        public DateTime RateValidFrom { get; set; }
    }
}
