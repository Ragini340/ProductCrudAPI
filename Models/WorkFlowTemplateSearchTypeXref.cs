using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateSearchTypeXref
    {
        public int? WorkFlowTemplateId { get; set; }
        public int? SearchTypeCdId { get; set; }
        public int WorkFlowTemplateSearchTypeXrefId { get; set; }

        public virtual SearchType? SearchTypeCd { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
