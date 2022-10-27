using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LoanInfo
    {
        public LoanInfo()
        {
            ServiceFileFees = new HashSet<ServiceFileFee>();
        }

        public int FileProcessId { get; set; }
        public int? LoanTypeCdId { get; set; }
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
        public int? PmtTypeCdId { get; set; }
        public int? PayablePeriodTypeCdId { get; set; }
        public int? LoanTerm { get; set; }
        public int? LoanTermTypeCdId { get; set; }
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
        public int? TrusteeId { get; set; }
        public int? MortgageBrokerId { get; set; }
        public decimal? OriginationFeePercent { get; set; }
        public decimal? OriginationFeeAdjAmt { get; set; }
        public decimal? DiscountPointPercent { get; set; }
        public decimal? DiscountPointAdjAmt { get; set; }
        public short? AaacreditChargeFlag { get; set; }
        public decimal? FundingAmt { get; set; }
        public short? IsSecuredByBothFlag { get; set; }
        public string? NameOfInsuredPerson { get; set; }
        public short? FundsReceivedFlag { get; set; }
        public int? LenderPayeeParentId { get; set; }
        public short? MbfeesToLoanProceedsFlag { get; set; }
        public decimal? OriginalPrincipalBalance { get; set; }
        public DateTime? GoodThruDate { get; set; }
        public int? AccountServiceTypeCdId { get; set; }
        public short? PayoffDemandStatusFlag { get; set; }
        public short? RestrictAutomaticUpdate { get; set; }
        public short? CcpcreditChargeFlag { get; set; }
        public decimal? OriginationPoints { get; set; }
        public decimal? DiscountPoints { get; set; }
        public string? MortgageInsCase { get; set; }
        public short? RestrictLenderUpdatesFlag { get; set; }
        public string? Reference2 { get; set; }
        public int? CcpdispFrmt { get; set; }
        public decimal? LenderPolicyLiability { get; set; }
        public long? ProposedInsuredTextId { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual FileBusinessParty? LenderPayeeParent { get; set; }
        public virtual TypeCdDmt? LoanTermTypeCd { get; set; }
        public virtual TypeCdDmt? LoanTypeCd { get; set; }
        public virtual FileBusinessParty? MortgageBroker { get; set; }
        public virtual TypeCdDmt? PayablePeriodTypeCd { get; set; }
        public virtual TypeCdDmt? PmtTypeCd { get; set; }
        public virtual RecordDocument? RecordDoc { get; set; }
        public virtual FileBusinessParty? Trustee { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
    }
}
