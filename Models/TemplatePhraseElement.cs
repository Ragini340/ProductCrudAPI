using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplatePhraseElement
    {
        public int TemplatePhraseElementId { get; set; }
        public int TemplatePhraseId { get; set; }
        public string? ConcatOperator { get; set; }
        public int DataElementId { get; set; }
        public string ElementIndex { get; set; } = null!;
        public string Operator { get; set; } = null!;
        public string ConditionalValue { get; set; } = null!;

        public virtual DataElementDmt DataElement { get; set; } = null!;
        public virtual TemplatePhrase TemplatePhrase { get; set; } = null!;
    }
}
