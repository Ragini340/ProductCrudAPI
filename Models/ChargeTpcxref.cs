using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ChargeTpcxref
    {
        public int ChargeTpcid { get; set; }
        public decimal? AdjustedAmount { get; set; }
        public decimal? TitlePremiumAmount { get; set; }
        public int? ChargeId { get; set; }
        public short? ShowOnCdpg3 { get; set; }
        public byte? PrimaryPolicyFlag { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Charge? Charge { get; set; }
    }
}
