using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ImageRestriction
    {
        public ImageRestriction()
        {
            ImageRestrictionAudits = new HashSet<ImageRestrictionAudit>();
        }

        public int ImageRestrictionId { get; set; }
        public int? AppId { get; set; }
        public int? RegionId { get; set; }
        public int AppYearOfRestriction { get; set; }
        public int RegionYearOfRestriction { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Descr { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ImageRestrictionAudit> ImageRestrictionAudits { get; set; }
    }
}
