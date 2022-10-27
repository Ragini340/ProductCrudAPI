using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterSearchTypeXref
    {
        public int? TemplateFilterGrpId { get; set; }
        public int? SearchTypeId { get; set; }
        public int TemplateFilterSearchTypeXrefId { get; set; }

        public virtual SearchType? SearchType { get; set; }
        public virtual TemplateFilterGrp? TemplateFilterGrp { get; set; }
    }
}
