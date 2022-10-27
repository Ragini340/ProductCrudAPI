using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileFee
    {
        public ServiceFileFee()
        {
            AgentNetPolicyNumbers = new HashSet<AgentNetPolicyNumber>();
            FaccadditionalParams = new HashSet<FaccadditionalParam>();
            FaccclosingCosts = new HashSet<FaccclosingCost>();
            Faccendorsements = new HashSet<Faccendorsement>();
            FaccrecordingFees = new HashSet<FaccrecordingFee>();
            FacctitlePolicies = new HashSet<FacctitlePolicy>();
            HudLineAssignmentForChargesFees = new HashSet<HudLineAssignmentForChargesFee>();
            InversePolicyFee = new HashSet<ServiceFileFee>();
            ProjectFileSiteFileServiceFileFeeXrefPfserviceFileFees = new HashSet<ProjectFileSiteFileServiceFileFeeXref>();
            ProjectFileSiteFileServiceFileFeeXrefSfserviceFileFees = new HashSet<ProjectFileSiteFileServiceFileFeeXref>();
            ServiceFileFeePaymentDetails = new HashSet<ServiceFileFeePaymentDetail>();
            ServiceFileSubFees = new HashSet<ServiceFileSubFee>();
            SffphysicalAddrs = new HashSet<SffphysicalAddr>();
            SplitFees = new HashSet<SplitFee>();
            Principals = new HashSet<Principal>();
        }

        public int ServiceFileFeeId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int FeeId { get; set; }
        public int? SplitFeeFlag { get; set; }
        public int? FeeTypeCdId { get; set; }
        public int GllookupId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int? TemplateId { get; set; }
        public int? GeographicTypeCdId { get; set; }
        public int StatusCd { get; set; }
        public string Descr { get; set; } = null!;
        public short DenyEditFlag { get; set; }
        public int? FileFeeCategoryTypeCdId { get; set; }
        public short StaticSeqNum { get; set; }
        public short CheckFlag { get; set; }
        public decimal SellerChargeAmt { get; set; }
        public decimal BuyerChargeAmt { get; set; }
        public decimal? BuyerSalesTaxAmt { get; set; }
        public decimal? SellerSalesTaxAmt { get; set; }
        public int? InvoiceId { get; set; }
        public short? InvoiceSeqNum { get; set; }
        public decimal? DiscountAmt { get; set; }
        public int? FileTransactionTypeCdId { get; set; }
        public int? FileProcessId { get; set; }
        public int? PaymentMethodTypeCdId { get; set; }
        public int? DefaultPaymentMethodTypeCdId { get; set; }
        public int? PayeeFileBusinessPartyId { get; set; }
        public decimal? DiscountPercent { get; set; }
        public int? PolicyId { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? FeeToBucket { get; set; }
        public short? CompanyIncomeFee { get; set; }
        public short? OfficeIncomeFee { get; set; }
        public short? TitleOfficerFee { get; set; }
        public short? EscrowOfficerFee { get; set; }
        public short? SalesRepFee { get; set; }
        public short? PremiumSalesTaxFlag { get; set; }
        public string? Comments { get; set; }
        public short? Otcflag { get; set; }
        public short? PromulgatedFee { get; set; }
        public short? RemittanceFee { get; set; }
        public short? ActionStatusId { get; set; }
        public int? FeeRateTypeId { get; set; }
        public short? SimultaneousOwnerFlag { get; set; }
        public int? PolicyFeeId { get; set; }
        public int? TransactionTypeId { get; set; }
        public int? LoanId { get; set; }
        public int? FeeOwningOfficeTypeCdId { get; set; }
        public int? FeeOwningOfficeBuid { get; set; }
        public byte? SplitFeeBwPropertiesFlag { get; set; }
        public short? Faccflag { get; set; }
        public short? GfeHudtypeCdId { get; set; }
        public short? GfeEntryTypeCdId { get; set; }
        public short? GfeEntryEditableFlag { get; set; }
        public short? GfeLenderDirectedFlag { get; set; }
        public short? GfeLenderDirEditableFlag { get; set; }
        public short? GfeThirdPartyEditableFlag { get; set; }
        public string? GfeThirdPartyNameDefault { get; set; }
        public short? GfePobobflag { get; set; }
        public short? SplitWithDirectOfficeFlag { get; set; }
        public short? TerritoryAllocationFlag { get; set; }
        public string? AdditionalDescr { get; set; }
        public decimal? ExchangeFeeAmt { get; set; }
        public int? ZeroFeeChargedTo { get; set; }
        public short? LenderRequiredFlag { get; set; }
        public short? EditLenderRequiredFlag { get; set; }
        public int? DefaultPaymentCategoryTypeCdId { get; set; }
        public decimal? FaccadjustedAmount { get; set; }
        public decimal? LoanEstimateUnrounded { get; set; }
        public decimal? LoanestimateRounded { get; set; }
        public string? LoanEstimateDescr { get; set; }
        public short? LoanEstDescrEdited { get; set; }
        public string? BuyerChargeSection { get; set; }
        public string? SellerChargeSection { get; set; }
        public short? LenderAffiliateFlag { get; set; }
        public decimal? SimPolicyAdjAmt { get; set; }
        public short? ShowOnCdpg3 { get; set; }
        public short? PartOf { get; set; }
        public short? PrimaryPolicyFlag { get; set; }
        public short? AggregateLpolicyFlag { get; set; }
        public short? EndorsementToPrimaryLpolicyFlag { get; set; }
        public short? BuyerDisplayL { get; set; }
        public short? SellerDisplayL { get; set; }
        public short? IsAllocationByProjectFile { get; set; }
        public short? DisclosureFeeFlag { get; set; }
        public short? FeeAutoSelectedFlag { get; set; }
        public short? T64excludeFlag { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public short? InclInFeeXfer { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? DefaultPaymentMethodTypeCd { get; set; }
        public virtual Fee Fee { get; set; } = null!;
        public virtual RateType? FeeRateType { get; set; }
        public virtual TypeCdDmt? FeeToBucketNavigation { get; set; }
        public virtual TypeCdDmt? FeeTypeCd { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt? FileFeeCategoryTypeCd { get; set; }
        public virtual FileProcess? FileProcess { get; set; }
        public virtual TypeCdDmt? FileTransactionTypeCd { get; set; }
        public virtual TypeCdDmt? GeographicTypeCd { get; set; }
        public virtual Invoice? Invoice { get; set; }
        public virtual LoanInfo? Loan { get; set; }
        public virtual FileBusinessParty? PayeeFileBusinessParty { get; set; }
        public virtual TypeCdDmt? PaymentMethodTypeCd { get; set; }
        public virtual ServiceFileFee? PolicyFee { get; set; }
        public virtual TransactionType? TransactionType { get; set; }
        public virtual ServiceFileFeePromulgatedRate? ServiceFileFeePromulgatedRate { get; set; }
        public virtual TempServiceFileFeeId? TempServiceFileFeeId { get; set; }
        public virtual ICollection<AgentNetPolicyNumber> AgentNetPolicyNumbers { get; set; }
        public virtual ICollection<FaccadditionalParam> FaccadditionalParams { get; set; }
        public virtual ICollection<FaccclosingCost> FaccclosingCosts { get; set; }
        public virtual ICollection<Faccendorsement> Faccendorsements { get; set; }
        public virtual ICollection<FaccrecordingFee> FaccrecordingFees { get; set; }
        public virtual ICollection<FacctitlePolicy> FacctitlePolicies { get; set; }
        public virtual ICollection<HudLineAssignmentForChargesFee> HudLineAssignmentForChargesFees { get; set; }
        public virtual ICollection<ServiceFileFee> InversePolicyFee { get; set; }
        public virtual ICollection<ProjectFileSiteFileServiceFileFeeXref> ProjectFileSiteFileServiceFileFeeXrefPfserviceFileFees { get; set; }
        public virtual ICollection<ProjectFileSiteFileServiceFileFeeXref> ProjectFileSiteFileServiceFileFeeXrefSfserviceFileFees { get; set; }
        public virtual ICollection<ServiceFileFeePaymentDetail> ServiceFileFeePaymentDetails { get; set; }
        public virtual ICollection<ServiceFileSubFee> ServiceFileSubFees { get; set; }
        public virtual ICollection<SffphysicalAddr> SffphysicalAddrs { get; set; }
        public virtual ICollection<SplitFee> SplitFees { get; set; }

        public virtual ICollection<Principal> Principals { get; set; }
    }
}
