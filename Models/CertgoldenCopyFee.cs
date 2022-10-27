using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CertgoldenCopyFee
    {
        public int FeeFeeId { get; set; }
        public int FeeClassTypeId { get; set; }
        public int FeeBusinessUnitId { get; set; }
        public string FeeObjectCd { get; set; } = null!;
        public string FeeGllookupId { get; set; } = null!;
        public int FeeFeeTypeCdId { get; set; }
        public int? FeeEscrowChargeTemplateId { get; set; }
        public int? FeeOtherTaxTypeCdId { get; set; }
        public int? FeeGeographicTypeCdId { get; set; }
        public int? FeeChargeToTypeCdId { get; set; }
        public int? FeeTemplateId { get; set; }
        public string? FeeDescr { get; set; }
        public short FeePremiumSalesTaxFlag { get; set; }
        public short FeeDenyEditFlag { get; set; }
        public decimal? FeeDefaultChargeAmt { get; set; }
        public int FeeStatusCd { get; set; }
        public int? FeeFeeToBucket { get; set; }
        public short? FeeCompanyIncomeFee { get; set; }
        public short? FeeOfficeIncomeFee { get; set; }
        public short? FeeTitleOfficerFee { get; set; }
        public short? FeeEscrowOfficerFee { get; set; }
        public short? FeeSalesRepFee { get; set; }
        public short? FeePromulgatedFee { get; set; }
        public short? FeeRemittanceFee { get; set; }
        public short? FeeGovernmentReportableFlag { get; set; }
        public short? FeeRateTypeFlag { get; set; }
        public short? FeeTransactionCodeFlag { get; set; }
        public string? FeeRecipientType { get; set; }
        public short? FeeFaccflag { get; set; }
        public int? FeeFeeOwningOfficeTypeCdId { get; set; }
        public short? FeeGfeHudtypeCdId { get; set; }
        public short? FeeSplitWithDirectOfficeFlag { get; set; }
        public short? FeeTerritoryAllocationFlag { get; set; }
        public int? FeeEndorsementTypeCdId { get; set; }
        public short? FeeInclBuyChrg1103 { get; set; }
        public string? FeeLoanEstimateDescr { get; set; }
        public short? FeeLenderChargeFlag { get; set; }
        public int EctEscrowChargeTemplateId { get; set; }
        public int EctClassTypeId { get; set; }
        public int? EctCalcBasePeriodTypeCdId { get; set; }
        public int EctChargeProcessTypeCdId { get; set; }
        public int? EctDefaultPmtMethodTypeCdId { get; set; }
        public int? EctChargeCategoryTypeCdId { get; set; }
        public short? EctSeqNum { get; set; }
        public int EctBusinessUnitId { get; set; }
        public string EctObjectCd { get; set; } = null!;
        public short EctStatusCd { get; set; }
        public short EctChargeOnlyFlag { get; set; }
        public short EctAdHocEntryFlag { get; set; }
        public string? EctDescr { get; set; }
        public short EctDescEditableFlag { get; set; }
        public short? EctHud1BuyerCharge { get; set; }
        public short? EctHud1BuyerCredit { get; set; }
        public short? EctHud1SellerCharge { get; set; }
        public short? EctHud1SellerCredit { get; set; }
        public short EctBuyerChargeFloatFlag { get; set; }
        public short EctBuyerCreditFloatFlag { get; set; }
        public short EctSellerChargeFloatFlag { get; set; }
        public short EctSellerCreditFloatFlag { get; set; }
        public short? EctBasisDays { get; set; }
        public short? EctFromDateInclFlag { get; set; }
        public short? EctToDateInclFlag { get; set; }
        public short? EctBuyerChargeSeqNum { get; set; }
        public short? EctBuyerCreditSeqNum { get; set; }
        public short? EctSellerChargeSeqNum { get; set; }
        public short? EctPaidBySellerAtCloseFlag { get; set; }
        public short? EctSellerCreditSeqNum { get; set; }
        public DateTime EctCreationDate { get; set; }
        public int EctCreationEmployeeId { get; set; }
        public DateTime? EctUpdatedDate { get; set; }
        public int? EctUpdatedEmployeeId { get; set; }
        public short? EctGfeHudtypeCdId { get; set; }
        public short? EctGfeEntryTypeCdId { get; set; }
        public short? EctGfeEntryEditableFlag { get; set; }
        public short? EctGfeLenderDirectedFlag { get; set; }
        public short? EctGfeLenderDirEditableFlag { get; set; }
        public short? EctGfeThirdPartyEditableFlag { get; set; }
        public string? EctGfeThirdPartyNameDefault { get; set; }
        public string? EctBuyerChargeSection { get; set; }
        public string? EctBuyerCreditSection { get; set; }
        public string? EctSellerChargeSection { get; set; }
        public string? EctSellerCreditSection { get; set; }
        public short? EctLenderRequiredFlag { get; set; }
        public short? EctEditLenderRequiredFlag { get; set; }
        public int? EctDefaultPaymentCategoryTypeCdId { get; set; }
        public int? EctParentEscrowChargeTemplateId { get; set; }
        public int? EctMismocategoryTypeCdId { get; set; }
        public int? EctMismotypeCdId { get; set; }
        public short? EctLenderAffiliateFlag { get; set; }
        public short? EctLenderChargeFlag { get; set; }
        public short? EctHud1BuyerChargeForCd { get; set; }
        public short? EctHud1BuyerCreditForCd { get; set; }
        public short? EctHud1SellerChargeForCd { get; set; }
        public short? EctHud1SellerCreditForCd { get; set; }
        public int CertgoldenCopyFeesId { get; set; }
    }
}
