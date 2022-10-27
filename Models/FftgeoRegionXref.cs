using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FftgeoRegionXref
    {
        public int FeeFilterTemplateId { get; set; }
        public int ClassTypeId { get; set; }
        public int? GeoRegionId { get; set; }
        public int FftgeoRegionXrefId { get; set; }

        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
    }
}
