using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateGeoRegionXrefDocPrep
    {
        public int TemplateId { get; set; }
        public int? GeoRegionId { get; set; }
        public int TemplateGeoRegionXrefDocPrepId { get; set; }

        public virtual GeographicRegion? GeoRegion { get; set; }
        public virtual TemplateInfoXref Template { get; set; } = null!;
    }
}
