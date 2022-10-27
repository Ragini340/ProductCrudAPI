using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwIbatransaction
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int IbatransactionId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public decimal Amount { get; set; }
        public string OrderNum { get; set; } = null!;
        public DateTime? IssueDate { get; set; }
        public string? InvestmentBankName { get; set; }
        public string? AccountNum { get; set; }
        public string Descr { get; set; } = null!;
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Fastbuid { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? BeneficiaryAddress1 { get; set; }
        public string? BeneficiaryAddress2 { get; set; }
        public string? BeneficiaryCity { get; set; }
        public string? BeneficiaryState { get; set; }
        public string? BeneficiaryZip { get; set; }
        public string BeneficaryTintype { get; set; } = null!;
        public string? BeneficaryTin { get; set; }
        public decimal? IbaaccBalance { get; set; }
        public string? OldInvestmentBankName { get; set; }
        public string? OldAccountNum { get; set; }
        public int IsoldBankFlag { get; set; }
    }
}
