using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadPropertyCollateral
    {
        public int CollateralId { get; set; }
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public string? CollateralTypeDescr { get; set; }
        public string? Description { get; set; }
        public DateTime? OriginDate { get; set; }
        public decimal? Amount { get; set; }
        public string? Originator { get; set; }
        public string? InvestmentUnits { get; set; }
        public string? InvestmentNumber { get; set; }
        public string? Intermediary { get; set; }
        public string? HolderName { get; set; }
        public string? HolderLocation { get; set; }
        public string? HolderInfo { get; set; }
        public string? Apn { get; set; }
        public string? County { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? GoodsStates { get; set; }
        public long? PropCollateralTextId { get; set; }
    }
}
