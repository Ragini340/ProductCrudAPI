using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadServiceFileFee
    {
        public int FileId { get; set; }
        public DateTime Dwdate { get; set; }
        public int ServiceFileFeeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public string? FeeTypeName { get; set; }
        public string? FileFeeCategoryName { get; set; }
        public string? GeographicTypeName { get; set; }
        public short CheckFlag { get; set; }
        public short DenyEditFlag { get; set; }
        public string Descr { get; set; } = null!;
        public decimal BuyerChargeAmt { get; set; }
        public decimal SellerChargeAmt { get; set; }
        public decimal? BuyerSalesTaxAmt { get; set; }
        public decimal? SellerSalesTaxAmt { get; set; }
        public decimal? DiscountAmt { get; set; }
        public decimal? DiscountPercent { get; set; }
        public int? PolicyId { get; set; }
    }
}
