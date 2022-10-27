using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SffphysicalAddr
    {
        public int ServiceFileFeeId { get; set; }
        public int PhysicalAddrId { get; set; }
        public decimal? SplitFeePercentage { get; set; }
        public decimal? SplitFeeAmount { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? GeoRegionId { get; set; }

        public virtual PhysicalAddr PhysicalAddr { get; set; } = null!;
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
