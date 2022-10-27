using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplatePhrase
    {
        public TemplatePhrase()
        {
            TemplatePhraseElements = new HashSet<TemplatePhraseElement>();
        }

        public int TemplatePhraseId { get; set; }
        public int ClassTypeId { get; set; }
        public int TemplateId { get; set; }
        public int? PhraseId { get; set; }
        public short SeqNum { get; set; }
        public short RequiredFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? PhraseMarkerId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Phrase? Phrase { get; set; }
        public virtual Template Template { get; set; } = null!;
        public virtual ICollection<TemplatePhraseElement> TemplatePhraseElements { get; set; }
    }
}
