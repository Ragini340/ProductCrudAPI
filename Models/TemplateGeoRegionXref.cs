using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateGeoRegionXref
    {
        public int TemplateId { get; set; }
        public int? GeoRegionId { get; set; }
        public int TemplateGeoRegionXrefId { get; set; }

        public virtual GeographicRegion? GeoRegion { get; set; }
        public virtual Template Template { get; set; } = null!;
    }
}
