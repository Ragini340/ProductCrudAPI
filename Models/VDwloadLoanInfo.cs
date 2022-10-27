using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadLoanInfo
    {
        public int FileProcessId { get; set; }
        public string? LoanTypeDescr { get; set; }
        public int? RecordDocId { get; set; }
        public decimal? LoanAmt { get; set; }
        public decimal? LoanLiability { get; set; }
        public DateTime? FundingDate { get; set; }
        public DateTime? SigningDate { get; set; }
        public DateTime? RescissionStart { get; set; }
        public short? RescissionDay { get; set; }
        public DateTime? RescissionEnd { get; set; }
        public DateTime? InterestFrom { get; set; }
        public DateTime? FirstPmtDue { get; set; }
        public decimal? PmtAmt { get; set; }
        public string? PmtTypeDescr { get; set; }
        public int? PayablePeriodTypeCdId { get; set; }
        public int? LoanTerm { get; set; }
        public string? LoanTermTypeDescr { get; set; }
        public DateTime? LoanDueDate { get; set; }
        public short? BalloonPmtFlag { get; set; }
        public short? AllocClauseFlag { get; set; }
        public short? PrePmtPenaltyFlag { get; set; }
        public short LateChargeFlag { get; set; }
        public decimal? LateChargePercent { get; set; }
        public short? LateChargeAfterDay { get; set; }
        public decimal? LateChargeAmt { get; set; }
        public DateTime? NextPmtDue { get; set; }
        public DateTime? InterestPaidThru { get; set; }
        public short? PaidThruEscrowFlag { get; set; }
        public short? RescissionEndOwflag { get; set; }
        public DateTime? NoteDated { get; set; }
        public decimal? OrigNoteAmt { get; set; }
        public long? TrustorMortgagerTextId { get; set; }
        public long? BenMortgageeTextId { get; set; }
        public long? AssignBenMortgageeTextId { get; set; }
        public long? HazardInsLossPayeeTextId { get; set; }
        public long? TitleInsMortgageeClauseTextId { get; set; }
        public int? MortgageBrokerId { get; set; }
        public decimal? OriginationFeePercent { get; set; }
        public decimal? OriginationFeeAdjAmt { get; set; }
        public decimal? DiscountPointPercent { get; set; }
        public decimal? DiscountPointAdjAmt { get; set; }
        public decimal? FundingAmt { get; set; }
        public string? NameOfInsuredPerson { get; set; }
    }
}
