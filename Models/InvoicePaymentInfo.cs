using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoicePaymentInfo
    {
        public int InvoicePaymentInfoId { get; set; }
        public int ImportInfoId { get; set; }
        public DateTime CreationDate { get; set; }
        public int? InvoiceId { get; set; }
        public string? PayerName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? BalanceAmount { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? ActionCode { get; set; }
        public string? DocumentNum { get; set; }
        public string? Action { get; set; }
        public string? Reason { get; set; }
        public long? OracleSeqNum { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual Invoice? Invoice { get; set; }
    }
}
