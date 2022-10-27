using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaxInstallment
    {
        public int TaxInstallmentId { get; set; }
        public int ClassTypeId { get; set; }
        public int TaxId { get; set; }
        public DateTime? PymtDate { get; set; }
        public decimal? PymtAmt { get; set; }
        public int? TaxPymtStatusTypeCdId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? GoodThruDate { get; set; }
        public string? VolumeNum { get; set; }
        public short? InstallmentNum { get; set; }
        public decimal? OverduePenaltyAmt { get; set; }
        public DateTime? DelinquentDate { get; set; }
        public short? PenaltyStatusCd { get; set; }
        public decimal? RedemptionAmt { get; set; }
        public DateTime? RedemptionDate { get; set; }
        public decimal? SpecialAssessmentAmt { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public decimal? AssessedValueAmt { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public decimal? AssessedImprovementAmt { get; set; }
        public decimal? PersonalPropertyValueAmt { get; set; }
        public short PayAtClose { get; set; }
        public string? CertOfPurchase { get; set; }
        public decimal? PartialPmtAmt { get; set; }
        public decimal? InterestAmt { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Tax Tax { get; set; } = null!;
        public virtual TypeCdDmt? TaxPymtStatusTypeCd { get; set; }
    }
}
