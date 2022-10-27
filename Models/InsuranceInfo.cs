using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InsuranceInfo
    {
        public int FileProcessId { get; set; }
        public int? UwfileBusinessPartyId { get; set; }
        public int? PremiumPeriodTypeCdId { get; set; }
        public decimal? PremiumAmt { get; set; }
        public short? PremiumDuration { get; set; }
        public short? CalcImpoundFlag { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual TypeCdDmt? PremiumPeriodTypeCd { get; set; }
        public virtual FileBusinessParty? UwfileBusinessParty { get; set; }
    }
}
