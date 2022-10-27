using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoicePaymentInfoNoMatch
    {
        public int ImportInfoId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int InvoiceId { get; set; }
        public long InvoiceNum { get; set; }
        public string FileNum { get; set; } = null!;
        public int OwnerOfficeId { get; set; }
        public byte[] Updts { get; set; } = null!;
        public int InvoicePaymentInfoNoMatchId { get; set; }
    }
}
