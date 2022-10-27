using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RealEstateBrokerSummary
    {
        public int RealEstateBrokerSummaryId { get; set; }
        public int FileId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
