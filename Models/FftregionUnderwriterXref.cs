using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FftregionUnderwriterXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int? RegionUnderwriterId { get; set; }
        public int FftregionUnderwriterXrefId { get; set; }

        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
        public virtual RegionUnderwriter? RegionUnderwriter { get; set; }
    }
}
