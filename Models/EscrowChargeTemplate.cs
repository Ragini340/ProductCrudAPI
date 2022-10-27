using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EscrowChargeTemplate
    {
        public EscrowChargeTemplate()
        {
            Charges = new HashSet<Charge>();
            EscrowChargeTemplateRuleListXrefs = new HashSet<EscrowChargeTemplateRuleListXref>();
            Fees = new HashSet<Fee>();
            InverseParentEscrowChargeTemplate = new HashSet<EscrowChargeTemplate>();
        }

        public int EscrowChargeTemplateId { get; set; }
        public int ClassTypeId { get; set; }
        public int? CalcBasePeriodTypeCdId { get; set; }
        public int ChargeProcessTypeCdId { get; set; }
        public int? DefaultPmtMethodTypeCdId { get; set; }
        public int? ChargeCategoryTypeCdId { get; set; }
        public short? SeqNum { get; set; }
        public int BusinessUnitId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public short StatusCd { get; set; }
        public short ChargeOnlyFlag { get; set; }
        public short AdHocEntryFlag { get; set; }
        public string? Descr { get; set; }
        public short DescEditableFlag { get; set; }
        public short? Hud1BuyerCharge { get; set; }
        public short? Hud1BuyerCredit { get; set; }
        public short? Hud1SellerCharge { get; set; }
        public short? Hud1SellerCredit { get; set; }
        public short BuyerChargeFloatFlag { get; set; }
        public short BuyerCreditFloatFlag { get; set; }
        public short SellerChargeFloatFlag { get; set; }
        public short SellerCreditFloatFlag { get; set; }
        public short? BasisDays { get; set; }
        public short? FromDateInclFlag { get; set; }
        public short? ToDateInclFlag { get; set; }
        public short? BuyerChargeSeqNum { get; set; }
        public short? BuyerCreditSeqNum { get; set; }
        public short? SellerChargeSeqNum { get; set; }
        public short? PaidBySellerAtCloseFlag { get; set; }
        public short? SellerCreditSeqNum { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? GfeHudtypeCdId { get; set; }
        public short? GfeEntryTypeCdId { get; set; }
        public short? GfeEntryEditableFlag { get; set; }
        public short? GfeLenderDirectedFlag { get; set; }
        public short? GfeLenderDirEditableFlag { get; set; }
        public short? GfeThirdPartyEditableFlag { get; set; }
        public string? GfeThirdPartyNameDefault { get; set; }
        public string? BuyerChargeSection { get; set; }
        public string? BuyerCreditSection { get; set; }
        public string? SellerChargeSection { get; set; }
        public string? SellerCreditSection { get; set; }
        public short? LenderRequiredFlag { get; set; }
        public short? EditLenderRequiredFlag { get; set; }
        public int? DefaultPaymentCategoryTypeCdId { get; set; }
        public int? ParentEscrowChargeTemplateId { get; set; }
        public int? MismocategoryTypeCdId { get; set; }
        public int? MismotypeCdId { get; set; }
        public short? LenderAffiliateFlag { get; set; }
        public short? LenderChargeFlag { get; set; }
        public short? Hud1BuyerChargeForCd { get; set; }
        public short? Hud1BuyerCreditForCd { get; set; }
        public short? Hud1SellerChargeForCd { get; set; }
        public short? Hud1SellerCreditForCd { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual TypeCdDmt? CalcBasePeriodTypeCd { get; set; }
        public virtual TypeCdDmt? ChargeCategoryTypeCd { get; set; }
        public virtual TypeCdDmt ChargeProcessTypeCd { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? DefaultPaymentCategoryTypeCd { get; set; }
        public virtual TypeCdDmt? DefaultPmtMethodTypeCd { get; set; }
        public virtual EscrowChargeTemplate? ParentEscrowChargeTemplate { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual ICollection<EscrowChargeTemplateRuleListXref> EscrowChargeTemplateRuleListXrefs { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<EscrowChargeTemplate> InverseParentEscrowChargeTemplate { get; set; }
    }
}
