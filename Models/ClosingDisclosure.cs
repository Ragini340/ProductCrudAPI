using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClosingDisclosure
    {
        public ClosingDisclosure()
        {
            CdadjustableInterestRates = new HashSet<CdadjustableInterestRate>();
            CdadjustablePayments = new HashSet<CdadjustablePayment>();
            CdcalculatingCashToCloses = new HashSet<CdcalculatingCashToClose>();
            CdloanTermClauses = new HashSet<CdloanTermClause>();
            CdpayoffsandPayments = new HashSet<CdpayoffsandPayment>();
            CdprojectedPaymentRanges = new HashSet<CdprojectedPaymentRange>();
            ClosingDisclosureGroupDescs = new HashSet<ClosingDisclosureGroupDesc>();
            ClosingDisclosureLenderInfos = new HashSet<ClosingDisclosureLenderInfo>();
            ClosingDisclosureReSequencedData = new HashSet<ClosingDisclosureReSequencedDatum>();
            ClosingDisclosureTransactionData = new HashSet<ClosingDisclosureTransactionDatum>();
        }

        public int ClosingDisclosureId { get; set; }
        public int? FileId { get; set; }
        public int? PrimarySettlementAgent { get; set; }
        public int? PrimaryBorrower { get; set; }
        public int? PrimarySeller { get; set; }
        public int? PrimaryLender { get; set; }
        public int? LatePaymentDays { get; set; }
        public decimal? LatePaymentFeeDollar { get; set; }
        public decimal? LatePaymentFeePercent { get; set; }
        public decimal? NonEscrowedPropertyCost { get; set; }
        public decimal? EstimatedPropertyCostsOverFirstYear { get; set; }
        public decimal? EscrowWaiverFee { get; set; }
        public string? EscrowedItemName { get; set; }
        public string? NonEscrowedItemName { get; set; }
        public decimal? TotalPayments { get; set; }
        public decimal? FinanceCharge { get; set; }
        public decimal? AmountFinanced { get; set; }
        public decimal? AnnualPercentageRate { get; set; }
        public decimal? TotalInterestPercentage { get; set; }
        public string? KeyFlagTypeCdIds { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? LoanProductTypeCdid { get; set; }
        public string? LoanProduct { get; set; }
        public int? LoanPurposeTypeCdid { get; set; }
        public string? LoanPurpose { get; set; }
        public int? LoanTermYear { get; set; }
        public int? LoanTermMonth { get; set; }
        public string? LoanTermOther { get; set; }
        public decimal? EstimatedTaxInsuranceAssesment { get; set; }
        public string? ProjectedPaymentEstimateOther { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? PrincipalAndInterest { get; set; }
        public int? PrincipalAndInterestTerm { get; set; }
        public string? PrincipalAndInterestTermOther { get; set; }
        public decimal? PrepaymentPenalty { get; set; }
        public decimal? BalloonPayment { get; set; }
        public string? ClosingCosts { get; set; }
        public string? CdloanTypeOtherDescr { get; set; }
        public string? CashToClose { get; set; }
        public string? LenderCreditsStatement { get; set; }
        public int? FbproleTypeCdId { get; set; }
        public int? LoanTypeCdId { get; set; }
        public int? SecondarySettlementAgent { get; set; }
        public string? Tpadescription { get; set; }
        public decimal? EscrowedPropertyCost { get; set; }
        public short? LatePaymentFeePercentTypeCdid { get; set; }
        public string? LatePaymentAdditionalComment { get; set; }
        public string? MonthlyEscrowPayment { get; set; }
        public bool? WillImprovementsBeMadeToProperty { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual ICollection<CdadjustableInterestRate> CdadjustableInterestRates { get; set; }
        public virtual ICollection<CdadjustablePayment> CdadjustablePayments { get; set; }
        public virtual ICollection<CdcalculatingCashToClose> CdcalculatingCashToCloses { get; set; }
        public virtual ICollection<CdloanTermClause> CdloanTermClauses { get; set; }
        public virtual ICollection<CdpayoffsandPayment> CdpayoffsandPayments { get; set; }
        public virtual ICollection<CdprojectedPaymentRange> CdprojectedPaymentRanges { get; set; }
        public virtual ICollection<ClosingDisclosureGroupDesc> ClosingDisclosureGroupDescs { get; set; }
        public virtual ICollection<ClosingDisclosureLenderInfo> ClosingDisclosureLenderInfos { get; set; }
        public virtual ICollection<ClosingDisclosureReSequencedDatum> ClosingDisclosureReSequencedData { get; set; }
        public virtual ICollection<ClosingDisclosureTransactionDatum> ClosingDisclosureTransactionData { get; set; }
    }
}
