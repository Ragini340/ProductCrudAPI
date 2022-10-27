using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwCpCreateDisbursementRecord
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? BusinessUnitId { get; set; }
        public int Disbursementid { get; set; }
        public string FileNum { get; set; } = null!;
        public string? DocumentNum { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? PayeeName { get; set; }
        public decimal? Amount { get; set; }
        public string? SmsbankCd { get; set; }
        public string? Description { get; set; }
        public string? Name1 { get; set; }
        public string? AccountNum { get; set; }
        public int? UserId { get; set; }
        public string ManualCheckFlag { get; set; } = null!;
        public string? UserName { get; set; }
        public string CheckType { get; set; } = null!;
        public int? DisbursementMethodTypeCdId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public string? ManualCheckReason { get; set; }
        public string? PayeeAddr { get; set; }
        public string? RoutingNum { get; set; }
        public string? PayeeName1 { get; set; }
        public string? PayeeName2 { get; set; }
        public string? PayeeName3 { get; set; }
        public string? PayeeName4 { get; set; }
    }
}
