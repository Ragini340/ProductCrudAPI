using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterGrp
    {
        public TemplateFilterGrp()
        {
            TemplateFilterByTypes = new HashSet<TemplateFilterByType>();
            TemplateFilterGrpGeoRegionXrefs = new HashSet<TemplateFilterGrpGeoRegionXref>();
            TemplateFilterOwningRegionXrefs = new HashSet<TemplateFilterOwningRegionXref>();
            TemplateFilterProgramTypeXrefs = new HashSet<TemplateFilterProgramTypeXref>();
            TemplateFilterSearchTypeXrefs = new HashSet<TemplateFilterSearchTypeXref>();
        }

        public int TemplateFilterGrpId { get; set; }
        public int TemplateId { get; set; }
        public int? StateId { get; set; }
        public int? CountyId { get; set; }
        public int? CityId { get; set; }
        public int? RoleTypeId { get; set; }
        public int? OwningRegionId { get; set; }
        public string? OwningRegion { get; set; }

        public virtual GeographicRegion? City { get; set; }
        public virtual GeographicRegion? County { get; set; }
        public virtual BusinessUnit? OwningRegionNavigation { get; set; }
        public virtual GeographicRegion? State { get; set; }
        public virtual Template Template { get; set; } = null!;
        public virtual ICollection<TemplateFilterByType> TemplateFilterByTypes { get; set; }
        public virtual ICollection<TemplateFilterGrpGeoRegionXref> TemplateFilterGrpGeoRegionXrefs { get; set; }
        public virtual ICollection<TemplateFilterOwningRegionXref> TemplateFilterOwningRegionXrefs { get; set; }
        public virtual ICollection<TemplateFilterProgramTypeXref> TemplateFilterProgramTypeXrefs { get; set; }
        public virtual ICollection<TemplateFilterSearchTypeXref> TemplateFilterSearchTypeXrefs { get; set; }
    }
}
