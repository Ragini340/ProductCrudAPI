using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClassTypeTypeCdXref
    {
        public ClassTypeTypeCdXref()
        {
            TemplateFilterByTypes = new HashSet<TemplateFilterByType>();
            TemplateFilterByTypesDocPreps = new HashSet<TemplateFilterByTypesDocPrep>();
        }

        public int ClassTypeId { get; set; }
        public int TypeCdId { get; set; }
        public int? SeqNum { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt TypeCd { get; set; } = null!;
        public virtual ICollection<TemplateFilterByType> TemplateFilterByTypes { get; set; }
        public virtual ICollection<TemplateFilterByTypesDocPrep> TemplateFilterByTypesDocPreps { get; set; }
    }
}
