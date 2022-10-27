using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TitleEscrowInfoLiabilityXref
    {
        public int TitleEscrowInfoLiabilityXrefId { get; set; }
        public int TitleEscrowInfoId { get; set; }
        public int LiabilityTypeCdId { get; set; }
        public decimal? Amount { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt LiabilityTypeCd { get; set; } = null!;
        public virtual TitleEscrowInfo TitleEscrowInfo { get; set; } = null!;
    }
}
