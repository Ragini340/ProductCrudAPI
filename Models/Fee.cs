using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Fee
    {
        public Fee()
        {
            CustomaryServiceFees = new HashSet<CustomaryServiceFee>();
            FeeFilterTemplateFeeXrefs = new HashSet<FeeFilterTemplateFeeXref>();
            FeeSetupChangeHistories = new HashSet<FeeSetupChangeHistory>();
            FeeTransferAllocations = new HashSet<FeeTransferAllocation>();
            InterOfficeFees = new HashSet<InterOfficeFee>();
            ServiceFees = new HashSet<ServiceFee>();
            ServiceFileFees = new HashSet<ServiceFileFee>();
            ServiceFileSubFees = new HashSet<ServiceFileSubFee>();
        }

        public int FeeId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int GllookupId { get; set; }
        public int FeeTypeCdId { get; set; }
        public int? EscrowChargeTemplateId { get; set; }
        public int? OtherTaxTypeCdId { get; set; }
        public int? GeographicTypeCdId { get; set; }
        public int? ChargeToTypeCdId { get; set; }
        public int? TemplateId { get; set; }
        public string? Descr { get; set; }
        public short PremiumSalesTaxFlag { get; set; }
        public short DenyEditFlag { get; set; }
        public decimal? DefaultChargeAmt { get; set; }
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? FeeToBucket { get; set; }
        public short? CompanyIncomeFee { get; set; }
        public short? OfficeIncomeFee { get; set; }
        public short? TitleOfficerFee { get; set; }
        public short? EscrowOfficerFee { get; set; }
        public short? SalesRepFee { get; set; }
        public short? PromulgatedFee { get; set; }
        public short? RemittanceFee { get; set; }
        public short? GovernmentReportableFlag { get; set; }
        public short? RateTypeFlag { get; set; }
        public short? TransactionCodeFlag { get; set; }
        public string? RecipientType { get; set; }
        public short? Faccflag { get; set; }
        public int? FeeOwningOfficeTypeCdId { get; set; }
        public short? GfeHudtypeCdId { get; set; }
        public short? SplitWithDirectOfficeFlag { get; set; }
        public short? TerritoryAllocationFlag { get; set; }
        public int? EndorsementTypeCdId { get; set; }
        public short? InclBuyChrg1103 { get; set; }
        public string? LoanEstimateDescr { get; set; }
        public short? LenderChargeFlag { get; set; }
        public byte? IsFaccclosingCostFee { get; set; }
        public short? DisclosureFee { get; set; }
        public short AutoSelectFlag { get; set; }
        public short? T64excludeFlag { get; set; }
        public short Uwglflag { get; set; }
        public string? StatCode { get; set; }
        public short? IsCplfee { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual TypeCdDmt? ChargeToTypeCd { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual EscrowChargeTemplate? EscrowChargeTemplate { get; set; }
        public virtual TypeCdDmt? FeeToBucketNavigation { get; set; }
        public virtual TypeCdDmt FeeTypeCd { get; set; } = null!;
        public virtual TypeCdDmt? GeographicTypeCd { get; set; }
        public virtual Gllookup Gllookup { get; set; } = null!;
        public virtual Template? Template { get; set; }
        public virtual ICollection<CustomaryServiceFee> CustomaryServiceFees { get; set; }
        public virtual ICollection<FeeFilterTemplateFeeXref> FeeFilterTemplateFeeXrefs { get; set; }
        public virtual ICollection<FeeSetupChangeHistory> FeeSetupChangeHistories { get; set; }
        public virtual ICollection<FeeTransferAllocation> FeeTransferAllocations { get; set; }
        public virtual ICollection<InterOfficeFee> InterOfficeFees { get; set; }
        public virtual ICollection<ServiceFee> ServiceFees { get; set; }
        public virtual ICollection<ServiceFileFee> ServiceFileFees { get; set; }
        public virtual ICollection<ServiceFileSubFee> ServiceFileSubFees { get; set; }
    }
}
