using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SsrolloutLogTobedeleted
    {
        public int FeatureId { get; set; }
        public DateTime RollOutDate { get; set; }
        public DateTime ActualRollOutDate { get; set; }
    }
}
