using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterOwningRegionXrefDocPrep
    {
        public int TemplateFilterOwningRegionXrefId { get; set; }
        public int TemplateFilterGrpId { get; set; }
        public int? OwningRegionId { get; set; }

        public virtual BusinessUnit? OwningRegion { get; set; }
        public virtual TemplateFilterGrpDocPrep TemplateFilterGrp { get; set; } = null!;
    }
}
