using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwIbadisbursementRecord
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? BusinessUnitId { get; set; }
        public int Disbursementid { get; set; }
        public string OrderNum { get; set; } = null!;
        public string? DocumentNum { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? PayeeName { get; set; }
        public string? InvestmentBankName { get; set; }
        public string? AccountNum { get; set; }
        public decimal? Amount { get; set; }
        public string? Descr { get; set; }
        public int? UserId { get; set; }
        public string? Fastbuid { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? BeneficiaryAddress1 { get; set; }
        public string? BeneficiaryAddress2 { get; set; }
        public string? BeneficiaryCity { get; set; }
        public string? BeneficiaryState { get; set; }
        public string? BeneficiaryZip { get; set; }
        public string BeneficaryTintype { get; set; } = null!;
        public string? BeneficaryTin { get; set; }
        public string? UserName { get; set; }
        public int? DisbursementMethodTypeCdId { get; set; }
        public int? TransactionTypeCdId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public int? SourceTypeCdId { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public string? EscrowAccountNum { get; set; }
        public string? SmsbankCode { get; set; }
        public string? EscrowTrustBankAccount { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public short? IsExchangeRegionFlag { get; set; }
    }
}
