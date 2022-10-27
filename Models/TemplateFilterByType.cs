using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterByType
    {
        public int? TemplateFilterGrpId { get; set; }
        public int? FilterType { get; set; }
        public int? FilterInfo { get; set; }
        public int TemplateFilterByTypesId { get; set; }

        public virtual ClassTypeTypeCdXref? Filter { get; set; }
        public virtual TemplateFilterGrp? TemplateFilterGrp { get; set; }
    }
}
