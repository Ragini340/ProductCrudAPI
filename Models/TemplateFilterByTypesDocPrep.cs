using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByTypesDocPrep
    {
        public int? TemplateFilterGrpId { get; set; }
        public int? FilterType { get; set; }
        public int? FilterInfo { get; set; }
        public int TemplateFilterByTypesDocPrepId { get; set; }

        public virtual ClassTypeTypeCdXref? Filter { get; set; }
        public virtual TemplateFilterGrpDocPrep? TemplateFilterGrp { get; set; }
    }
}
