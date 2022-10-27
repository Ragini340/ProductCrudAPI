using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateInfoXref
    {
        public TemplateInfoXref()
        {
            InverseNextTemplateVersion = new HashSet<TemplateInfoXref>();
            TemplateFilterGrpDocPreps = new HashSet<TemplateFilterGrpDocPrep>();
            TemplateGeoRegionXrefDocPreps = new HashSet<TemplateGeoRegionXrefDocPrep>();
            TemplateProductTypeXrefDocPreps = new HashSet<TemplateProductTypeXrefDocPrep>();
        }

        public int TemplateId { get; set; }
        public byte? NotificationCandidateFlg { get; set; }
        public short UnderConstFlg { get; set; }
        public int? NextTemplateVersionId { get; set; }
        public int BusinessUnitId { get; set; }
        public int DocTypeCdId { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public string ObjectCd { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public short? PhraseExists { get; set; }
        public short ReadyToTestFlag { get; set; }

        public virtual TemplateInfoXref? NextTemplateVersion { get; set; }
        public virtual ICollection<TemplateInfoXref> InverseNextTemplateVersion { get; set; }
        public virtual ICollection<TemplateFilterGrpDocPrep> TemplateFilterGrpDocPreps { get; set; }
        public virtual ICollection<TemplateGeoRegionXrefDocPrep> TemplateGeoRegionXrefDocPreps { get; set; }
        public virtual ICollection<TemplateProductTypeXrefDocPrep> TemplateProductTypeXrefDocPreps { get; set; }
    }
}
