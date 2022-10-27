using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Phrase
    {
        public Phrase()
        {
            Docphrases = new HashSet<Docphrase>();
            InverseNextPhraseVersion = new HashSet<Phrase>();
            PhraseElements = new HashSet<PhraseElement>();
            PhraseHistories = new HashSet<PhraseHistory>();
            RealProperties = new HashSet<RealProperty>();
            TemplatePageLayoutContinueFromPhrases = new HashSet<TemplatePageLayout>();
            TemplatePageLayoutContinueOnPhrases = new HashSet<TemplatePageLayout>();
            TemplatePageLayoutFooterPhrases = new HashSet<TemplatePageLayout>();
            TemplatePageLayoutHeaderPhrases = new HashSet<TemplatePageLayout>();
            TemplatePhrases = new HashSet<TemplatePhrase>();
            CountyInfos = new HashSet<CountyInfo>();
        }

        public int PhraseId { get; set; }
        public int ClassTypeId { get; set; }
        public int PhraseGrpId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int? NextPhraseVersionId { get; set; }
        public string? Name { get; set; }
        public int StatusCd { get; set; }
        public short EditableFlag { get; set; }
        public string? FontName { get; set; }
        public short? FontSize { get; set; }
        public short LinkPhraseFlag { get; set; }
        public decimal TopMarginValue { get; set; }
        public decimal? LeftMarginValue { get; set; }
        public decimal? RightMarginValue { get; set; }
        public decimal? BottomMarginValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public long? PhraseTextId { get; set; }
        public short? JustifyTextFlg { get; set; }
        public short UnderConstFlg { get; set; }
        public short DocPrepRegOnlyFlg { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual Phrase? NextPhraseVersion { get; set; }
        public virtual PhraseGrp PhraseGrp { get; set; } = null!;
        public virtual Employee? StatusChgUser { get; set; }
        public virtual ICollection<Docphrase> Docphrases { get; set; }
        public virtual ICollection<Phrase> InverseNextPhraseVersion { get; set; }
        public virtual ICollection<PhraseElement> PhraseElements { get; set; }
        public virtual ICollection<PhraseHistory> PhraseHistories { get; set; }
        public virtual ICollection<RealProperty> RealProperties { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayoutContinueFromPhrases { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayoutContinueOnPhrases { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayoutFooterPhrases { get; set; }
        public virtual ICollection<TemplatePageLayout> TemplatePageLayoutHeaderPhrases { get; set; }
        public virtual ICollection<TemplatePhrase> TemplatePhrases { get; set; }

        public virtual ICollection<CountyInfo> CountyInfos { get; set; }
    }
}
