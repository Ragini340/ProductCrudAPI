using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdsplitOwnerPolicyAmt
    {
        public int PolicyId { get; set; }
        public int? ApplyTo { get; set; }
        public decimal? SplitPercent { get; set; }
        public decimal? BuyerSplitAmt { get; set; }
        public decimal? SellerSplitAmt { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TypeCdid { get; set; }
        public int CdsplitPolicyId { get; set; }

        public virtual TypeCdDmt? TypeCd { get; set; }
    }
}
