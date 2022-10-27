using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadEscrowChargeTemplate
    {
        public int EscrowChargeTemplateId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
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
    }
}
