using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class StagingInvoicePaymentInfo
    {
        public int InvoicePaymentInfoId { get; set; }
        public int ImportInfoId { get; set; }
        public DateTime CreationDate { get; set; }
        public int? InvoiceId { get; set; }
        public long InvoiceNum { get; set; }
        public byte InvSeqNo { get; set; }
        public string FileNum { get; set; } = null!;
        public int OwnerOfficeId { get; set; }
        public string? PayerName { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CumulativeAmount { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? ActionCode { get; set; }
        public string? DocumentNum { get; set; }
        public string? Action { get; set; }
        public string? Reason { get; set; }
        public decimal? BalAmt { get; set; }
        public long? OracleSeqNum { get; set; }
    }
}
