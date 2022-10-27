using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Template
    {
        public Template()
        {
            Documents = new HashSet<Document>();
            Fees = new HashSet<Fee>();
            InverseNextTemplateVersion = new HashSet<Template>();
            TemplateFilterGrps = new HashSet<TemplateFilterGrp>();
            TemplateGeoRegionXrefs = new HashSet<TemplateGeoRegionXref>();
            TemplateHistories = new HashSet<TemplateHistory>();
            TemplatePageLayouts = new HashSet<TemplatePageLayout>();
            TemplatePhrases = new HashSet<TemplatePhrase>();
            TemplateProductTypeXrefs = new HashSet<TemplateProductTypeXref>();
            Packages = new HashSet<Package>();
        }

        public int TemplateId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int? NextTemplateVersionId { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public short AutoRefreshDataElemFlag { get; set; }
        public string? AdhocPhrFontName { get; set; }
        public short? AdhocPhrFontSize { get; set; }
        public decimal? AdhocPhrTopMarginValue { get; set; }
        public decimal? AdhocPhrLeftMarginValue { get; set; }
        public decimal? AdhocPhrRightMarginValue { get; set; }
        public decimal? AdhocPhrBottomMarginValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public int BusinessUnitId { get; set; }
        public int DocTypeCdId { get; set; }
        public short UnderConstFlg { get; set; }
        public short? ColorAllowedFlag { get; set; }
        public byte? NotificationCandidateYesNo { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual DocTypeDmt DocTypeCd { get; set; } = null!;
        public virtual Template? NextTemplateVersion { get; set; }
        public virtual Employee? StatusChgUser { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<Template> InverseNextTemplateVersion { get; set; }
        public virtual ICollection<TemplateFilterGrp> TemplateFilterGrps { get; set; }
        public virtual ICollection<TemplateGeoRegionXref> TemplateGeoRegionXrefs { get; set; }
        public virtual ICollection<TemplateHistory> TemplateHistories { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayouts { get; set; }
        public virtual ICollection<TemplatePhrase> TemplatePhrases { get; set; }
        public virtual ICollection<TemplateProductTypeXref> TemplateProductTypeXrefs { get; set; }

        public virtual ICollection<Package> Packages { get; set; }
    }
}
