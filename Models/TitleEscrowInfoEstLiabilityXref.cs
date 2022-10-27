using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TitleEscrowInfoEstLiabilityXref
    {
        public int TitleEscrowInfoId { get; set; }
        public decimal? EstOwnerPolicyLiability { get; set; }
        public decimal? EstTitlePremium { get; set; }
        public decimal? EstFirstLenderPolicyLiability { get; set; }
        public decimal? EstSecondLenderPolicyLiability { get; set; }
        public string? Notes { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;
    }
}
