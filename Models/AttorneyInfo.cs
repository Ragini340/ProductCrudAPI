using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AttorneyInfo
    {
        public int FileProcessId { get; set; }
        public decimal? RetainedAmtByAttorney { get; set; }
        public short? TitlePremiumAdjustment { get; set; }
        public short? DisplayAggregateOnCd { get; set; }

        public virtual FileProcess FileProcess { get; set; } = null!;
    }
}
