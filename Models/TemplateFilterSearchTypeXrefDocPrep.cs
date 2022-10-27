using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateFilterSearchTypeXrefDocPrep
    {
        public int? TemplateFilterGrpId { get; set; }
        public int? SearchTypeId { get; set; }
        public int TemplateFilterSearchTypeXrefDocPrepId { get; set; }

        public virtual SearchType? SearchType { get; set; }
        public virtual TemplateFilterGrpDocPrep? TemplateFilterGrp { get; set; }
    }
}
