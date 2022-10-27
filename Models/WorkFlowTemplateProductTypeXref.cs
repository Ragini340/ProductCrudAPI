using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateProductTypeXref
    {
        public int WorkFlowTemplateProductTypeXrefId { get; set; }
        public int? WorkFlowTemplateId { get; set; }
        public int? ProductTypeCdId { get; set; }

        public virtual TypeCdDmt? ProductTypeCd { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
