using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Ibarate
    {
        public int RateId { get; set; }
        public int IbabankProductId { get; set; }
        public decimal? MinAmt { get; set; }
        public decimal? MaxAmt { get; set; }
        public decimal? Apy { get; set; }
        public DateTime? EffectiveDate { get; set; }

        public virtual IbabankProduct IbabankProduct { get; set; } = null!;
    }
}
