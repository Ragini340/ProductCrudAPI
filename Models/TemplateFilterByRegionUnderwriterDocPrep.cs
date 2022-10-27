using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByRegionUnderwriterDocPrep
    {
        public int TemplateFilterGrpId { get; set; }
        public int? RegionUnderwriterId { get; set; }
        public int TemplateFilterByRegionUnderwriterDocPrepId { get; set; }

        public virtual RegionUnderwriter? RegionUnderwriter { get; set; }
        public virtual TemplateFilterGrpDocPrep TemplateFilterGrp { get; set; } = null!;
    }
}
