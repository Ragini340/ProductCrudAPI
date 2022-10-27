using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterGrpDocPrep
    {
        public TemplateFilterGrpDocPrep()
        {
            TemplateFilterByBusinessPartyIdDocPreps = new HashSet<TemplateFilterByBusinessPartyIdDocPrep>();
            TemplateFilterByOwningOfficeIdDocPreps = new HashSet<TemplateFilterByOwningOfficeIdDocPrep>();
            TemplateFilterByRegionUnderwriterDocPreps = new HashSet<TemplateFilterByRegionUnderwriterDocPrep>();
            TemplateFilterByTypesDocPreps = new HashSet<TemplateFilterByTypesDocPrep>();
            TemplateFilterGrpGeoRegionXrefDocPreps = new HashSet<TemplateFilterGrpGeoRegionXrefDocPrep>();
            TemplateFilterOwningRegionXrefDocPreps = new HashSet<TemplateFilterOwningRegionXrefDocPrep>();
            TemplateFilterProgramTypeXrefDocPreps = new HashSet<TemplateFilterProgramTypeXrefDocPrep>();
            TemplateFilterSearchTypeXrefDocPreps = new HashSet<TemplateFilterSearchTypeXrefDocPrep>();
        }

        public int TemplateFilterGrpId { get; set; }
        public int TemplateId { get; set; }
        public int? StateId { get; set; }
        public int? CountyId { get; set; }
        public int? CityId { get; set; }
        public int? RoleTypeId { get; set; }
        public int? OwningRegionId { get; set; }
        public byte? ServiceAccountFlag { get; set; }
        public byte? VisibleFlag { get; set; }

        public virtual GeographicRegion? City { get; set; }
        public virtual GeographicRegion? County { get; set; }
        public virtual BusinessUnit? OwningRegion { get; set; }
        public virtual GeographicRegion? State { get; set; }
        public virtual TemplateInfoXref Template { get; set; } = null!;
        public virtual ICollection<TemplateFilterByBusinessPartyIdDocPrep> TemplateFilterByBusinessPartyIdDocPreps { get; set; }
        public virtual ICollection<TemplateFilterByOwningOfficeIdDocPrep> TemplateFilterByOwningOfficeIdDocPreps { get; set; }
        public virtual ICollection<TemplateFilterByRegionUnderwriterDocPrep> TemplateFilterByRegionUnderwriterDocPreps { get; set; }
        public virtual ICollection<TemplateFilterByTypesDocPrep> TemplateFilterByTypesDocPreps { get; set; }
        public virtual ICollection<TemplateFilterGrpGeoRegionXrefDocPrep> TemplateFilterGrpGeoRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterOwningRegionXrefDocPrep> TemplateFilterOwningRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterProgramTypeXrefDocPrep> TemplateFilterProgramTypeXrefDocPreps { get; set; }
        public virtual ICollection<TemplateFilterSearchTypeXrefDocPrep> TemplateFilterSearchTypeXrefDocPreps { get; set; }
    }
}
