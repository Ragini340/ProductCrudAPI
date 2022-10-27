using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaxRateInfo
    {
        public int TaxRateInfoId { get; set; }
        public int ClassTypeId { get; set; }
        public int GeoRegionId { get; set; }
        public int TaxRateTypeCdId { get; set; }
        public int TaxBaseMethodTypeCdId { get; set; }
        public decimal? TaxRatePercent { get; set; }
        public decimal? TaxRateAmt { get; set; }
        public decimal? PerDollarAmt { get; set; }
        public DateTime EffectiveDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual GeographicRegion GeoRegion { get; set; } = null!;
        public virtual TypeCdDmt TaxBaseMethodTypeCd { get; set; } = null!;
        public virtual TypeCdDmt TaxRateTypeCd { get; set; } = null!;
    }
}
