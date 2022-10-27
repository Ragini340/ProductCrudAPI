using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFileSiteFileChargeXref
    {
        public int ProjectFileSiteFileChargeXrefId { get; set; }
        public int PfchargeId { get; set; }
        public int SfchargeId { get; set; }
        public decimal? SfbuyerChargePercent { get; set; }
        public decimal? SfbuyerCreditPercent { get; set; }
        public decimal? SfsellerChargePercent { get; set; }
        public decimal? SfsellerCreditPercent { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public decimal? SffileChargePercent { get; set; }

        public virtual Charge Pfcharge { get; set; } = null!;
        public virtual Charge Sfcharge { get; set; } = null!;
    }
}
