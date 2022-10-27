using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterGrpDocPrepMap
    {
        public int NewTemplateFilterGrpId { get; set; }
        public int TemplateFilterGrpId { get; set; }
        public int NewTemplateId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TargetRegionId { get; set; }
    }
}
