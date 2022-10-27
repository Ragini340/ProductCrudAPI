using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwIbaaccruedInterest
    {
        public long SmstranslogId { get; set; }
        public int? ExtractId { get; set; }
        public int RecordRowId { get; set; }
        public int RecordClassTypeId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public decimal? Amount { get; set; }
        public string OrderNum { get; set; } = null!;
        public DateTime? IssueDate { get; set; }
        public string? InvestmentBankName { get; set; }
        public string? AccountNum { get; set; }
        public string Descr { get; set; } = null!;
        public string? Fastbuid { get; set; }
        public string? BeneficiaryName { get; set; }
        public string? BeneficiaryAddress1 { get; set; }
        public string? BeneficiaryAddress2 { get; set; }
        public string? BeneficiaryCity { get; set; }
        public string? BeneficiaryState { get; set; }
        public string? BeneficiaryZip { get; set; }
        public string BeneficaryTintype { get; set; } = null!;
        public string? BeneficaryTin { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? DocumentNum { get; set; }
        public string? EscrowAccountNum { get; set; }
        public string? SmsbankCode { get; set; }
        public string? EscrowTrustBankAccount { get; set; }
        public string? DepositorName { get; set; }
    }
}
