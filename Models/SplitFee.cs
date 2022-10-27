using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SplitFee
    {
        public int SplitFeeId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int FeeOwnerFbpid { get; set; }
        public int FeeSplitFbpid { get; set; }
        public decimal? StandardSplitFeePercentage { get; set; }
        public int? PaymentMethodTypeCdId { get; set; }
        public decimal? SplitPercentage { get; set; }
        public decimal? SplitAmt { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual FileBusinessParty FeeOwnerFbp { get; set; } = null!;
        public virtual FileBusinessParty FeeSplitFbp { get; set; } = null!;
        public virtual TypeCdDmt? PaymentMethodTypeCd { get; set; }
        public virtual ServiceFileFee ServiceFileFee { get; set; } = null!;
    }
}
