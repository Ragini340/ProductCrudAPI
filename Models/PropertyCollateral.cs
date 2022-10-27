using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PropertyCollateral
    {
        public PropertyCollateral()
        {
            GeoRegions = new HashSet<GeographicRegion>();
        }

        public int CollateralId { get; set; }
        public int ClassTypeId { get; set; }
        public int CollateralTypeCd { get; set; }
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
        public long? TextId { get; set; }
        public int TitleEscrowInfoId { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? ObjectCd { get; set; }

        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;

        public virtual ICollection<GeographicRegion> GeoRegions { get; set; }
    }
}
