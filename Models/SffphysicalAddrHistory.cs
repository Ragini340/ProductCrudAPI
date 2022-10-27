using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SffphysicalAddrHistory
    {
        public int ServiceFileFeeId { get; set; }
        public int PhysicalAddrId { get; set; }
        public decimal? SplitFeePercentage { get; set; }
        public decimal? SplitFeeAmount { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? GeoRegionId { get; set; }
        public int? DisbursementId { get; set; }
        public long SffphysicalAddrHistoryId { get; set; }
    }
}
