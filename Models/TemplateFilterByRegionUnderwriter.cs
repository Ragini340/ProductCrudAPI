using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByRegionUnderwriter
    {
        public int TemplateFilterGrpId { get; set; }
        public int? RegionUnderwriterId { get; set; }
        public int TemplateFilterByRegionUnderwriterId { get; set; }

        public virtual RegionUnderwriter? RegionUnderwriter { get; set; }
    }
}
