using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplatePageLayout
    {
        public int TemplatePageLayoutId { get; set; }
        public int ClassTypeId { get; set; }
        public int TemplateId { get; set; }
        public int PageTypeCdId { get; set; }
        public string PageRangeStart { get; set; } = null!;
        public string? PageRangeEnd { get; set; }
        public int? HeaderPhraseId { get; set; }
        public int? FooterPhraseId { get; set; }
        public int? ContinueOnPhraseId { get; set; }
        public int? ContinueFromPhraseId { get; set; }
        public decimal? TopMarginValue { get; set; }
        public decimal? LeftMarginValue { get; set; }
        public decimal? RightMarginValue { get; set; }
        public decimal? BottomMarginValue { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Phrase? ContinueFromPhrase { get; set; }
        public virtual Phrase? ContinueOnPhrase { get; set; }
        public virtual Phrase? FooterPhrase { get; set; }
        public virtual Phrase? HeaderPhrase { get; set; }
        public virtual TypeCdDmt PageTypeCd { get; set; } = null!;
        public virtual Template Template { get; set; } = null!;
    }
}
