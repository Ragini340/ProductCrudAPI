using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwInescrowdepositRepost
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public int StatusTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string FileNum { get; set; } = null!;
        public string ReceiptNum { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public string? SmsbankCd { get; set; }
        public string? AccountNum { get; set; }
        public string? BankName { get; set; }
        public string? Comments { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public short? IsExchangeRegionFlag { get; set; }
    }
}
