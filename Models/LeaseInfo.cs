using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LeaseInfo
    {
        public int FileProcessId { get; set; }
        public int? LeasePeriodTypeCdId { get; set; }
        public decimal? LeaseAmt { get; set; }
        public short? LeaseDuration { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
        public virtual TypeCdDmt? LeasePeriodTypeCd { get; set; }
    }
}
