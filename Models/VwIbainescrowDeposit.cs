using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwIbainescrowDeposit
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int InEscrowId { get; set; }
        public string DocumentNum { get; set; } = null!;
        public decimal Amount { get; set; }
        public string OrderNum { get; set; } = null!;
        public DateTime IssueDate { get; set; }
        public string? InvestmentBankName { get; set; }
        public int? AdjustmentTypeCdId { get; set; }
        public int? AdjustedTransactionId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public int StatusTypeCdId { get; set; }
        public int RepresentingTypeCdId { get; set; }
        public string? AccountNum { get; set; }
        public string? Descr { get; set; }
        public string? Fastbuid { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? BeneficiaryAddress1 { get; set; }
        public string? BeneficiaryAddress2 { get; set; }
        public string? BeneficiaryCity { get; set; }
        public string? BeneficiaryState { get; set; }
        public string? BeneficiaryZip { get; set; }
        public string BeneficaryTintype { get; set; } = null!;
        public string? BeneficaryTin { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public int? AdjustmentReasonTypeCdId { get; set; }
        public int? DepositorTypeCdId { get; set; }
        public string? DepositorName { get; set; }
        public string? Comments { get; set; }
        public int? CorrectingTransactionId { get; set; }
        public string? EscrowAccountNum { get; set; }
        public string? SmsbankCode { get; set; }
        public string? EscrowTrustBankAccount { get; set; }
        public short? UpdateTrustAccountingFlag { get; set; }
        public short? IsExchangeRegionFlag { get; set; }
    }
}
