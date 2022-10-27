using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadFileProcess
    {
        public int FileProcessId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public string? ProcessTypeCdDescr { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int FileId { get; set; }
        public short? SeqNum { get; set; }
        public short? FileProcessStatusFlag { get; set; }
        public string? Comments { get; set; }
        public int UpdatedEmployeeId { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? AmountDue { get; set; }
        public string? AmtDuePeriodTypeDescr { get; set; }
        public int? MgmtCoFileBusinessPartyId { get; set; }
        public decimal? RetainedAmtByAttorney { get; set; }
        public DateTime? HoldDate { get; set; }
        public short? ReleaseInDay { get; set; }
        public DateTime? EstReleaseDate { get; set; }
        public DateTime? ActualReleaseDate { get; set; }
        public short? AgreementFlag { get; set; }
        public int? PaidByTypeCdId { get; set; }
        public decimal? ChargeAmtNotToExceed { get; set; }
        public decimal? PerDiemAmount { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public int? UwfileBusinessPartyId { get; set; }
        public int? PremiumPeriodTypeCdId { get; set; }
        public decimal? PremiumAmt { get; set; }
        public short? PremiumDuration { get; set; }
        public int? LeasePeriodTypeCdId { get; set; }
        public decimal? LeaseAmt { get; set; }
        public short? LeaseDuration { get; set; }
        public decimal? CommissionPercent { get; set; }
        public decimal? CreditToBuyerAmt { get; set; }
        public decimal? CreditTosellerAmt { get; set; }
        public decimal? CreditToSellerBrokerAmt { get; set; }
        public decimal? CreditToBuyerBrokerAmt { get; set; }
        public string? SurveyNote { get; set; }
        public string? FurnishedByTypeDescr { get; set; }
        public short? WithInDays { get; set; }
        public DateTime? InspOrderDate { get; set; }
        public DateTime? InspDuedate { get; set; }
        public DateTime? InspFollowUpDate { get; set; }
        public DateTime? InspCompleteDate { get; set; }
        public DateTime? InspReportDate { get; set; }
    }
}
