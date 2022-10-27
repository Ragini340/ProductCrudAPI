using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class StateBusSegMapping
    {
        public int StateBusSegMappingId { get; set; }
        public int GeographicRegionId { get; set; }
        public int? BusinessSegmentId { get; set; }
        public int? TransactionTypeId { get; set; }

        public virtual TypeCdDmt? BusinessSegment { get; set; }
        public virtual GeographicRegion GeographicRegion { get; set; } = null!;
        public virtual TypeCdDmt? TransactionType { get; set; }
    }
}
