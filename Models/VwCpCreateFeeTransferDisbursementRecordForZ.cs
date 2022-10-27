using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwCpCreateFeeTransferDisbursementRecordForZ
    {
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public string FileNum { get; set; } = null!;
        public int DisbursementId { get; set; }
        public string? DocumentNum { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? Amount { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public int StatusCd { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public string? PayeeName { get; set; }
        public int? DisbursementMethodTypeCdId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public string? SmsbankCd { get; set; }
        public string? Name1 { get; set; }
        public string? AccountNum { get; set; }
    }
}
