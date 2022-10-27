using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvoiceHistory
    {
        public int InvoiceHistoryId { get; set; }
        public int InvoiceId { get; set; }
        public long? InvoiceNum { get; set; }
        public short? InvoiceSeqNum { get; set; }
        public string? Descr { get; set; }
        public DateTime? InvoiceStatusDate { get; set; }
        public int? InvoicedByEmployeeId { get; set; }
        public int InvoiceStatusCdId { get; set; }
        public DateTime? ExportRequestDate { get; set; }
        public int? ExportInfoId { get; set; }
        public decimal BuyerChargeAmt { get; set; }
        public decimal SellerChargeAmt { get; set; }
        public decimal BuyerSalesTaxAmt { get; set; }
        public decimal SellerSalesTaxAmt { get; set; }
        public int? ActionStatusId { get; set; }
        public int GlLookupId { get; set; }
        public int FeeId { get; set; }
        public int FeeTypeCdId { get; set; }
        public int? ServicefilefeeId { get; set; }
        public short? PremiumSalesTaxFlag { get; set; }
        public decimal? DiscountAmt { get; set; }
        public decimal? DiscountPercent { get; set; }
        public int? PolicyId { get; set; }
        public short? Otcflag { get; set; }
        public short CheckFlag { get; set; }
        public short BuyerAmtChgFlag { get; set; }
        public short SellerAmtChgFlag { get; set; }
        public int? TitleOwningOfficeId { get; set; }
        public int? EscrowOwningOfficeId { get; set; }
        public int? TitleOfficerId { get; set; }
        public int? EscrowOfficerId { get; set; }
        public short BuyerSalesTaxAmtChgFlag { get; set; }
        public short SellerSalesTaxAmtChgFlag { get; set; }

        public virtual Employee? EscrowOfficer { get; set; }
        public virtual BusinessUnit? EscrowOwningOffice { get; set; }
        public virtual Employee? TitleOfficer { get; set; }
        public virtual BusinessUnit? TitleOwningOffice { get; set; }
    }
}
