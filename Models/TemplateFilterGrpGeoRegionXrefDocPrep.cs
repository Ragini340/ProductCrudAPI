using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterGrpGeoRegionXrefDocPrep
    {
        public int TemplateFilterGrpId { get; set; }
        public int ClassTypeId { get; set; }
        public int? GeoRegionId { get; set; }
        public int TemplateFilterGrpGeoRegionXrefDocPrepId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual GeographicRegion? GeoRegion { get; set; }
        public virtual TemplateFilterGrpDocPrep TemplateFilterGrp { get; set; } = null!;
    }
}
