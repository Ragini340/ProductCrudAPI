using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ImageRestrictionAudit
    {
        public int ImageRestrictionAuditId { get; set; }
        public int? ImageRestrictionId { get; set; }
        public int? AppYearOfRestrictionOld { get; set; }
        public int? RegionYearOfRestrictionOld { get; set; }
        public string? Descr { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ImageRestriction? ImageRestriction { get; set; }
    }
}
