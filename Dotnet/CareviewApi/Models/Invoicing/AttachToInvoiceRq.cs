using System;
using System.Collections.Generic;
using System.Text;

namespace CareviewApi.Models.Invoicing
{
    public class AttachToInvoiceRq
    {
        public string Reference { get; set; }
        public string Filename { get; set; }
        public byte[] AttachmentData { get; set; }
    }
}
