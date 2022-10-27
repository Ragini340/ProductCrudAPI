using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateApnxref
    {
        public int WorkFlowTemplateApnxrefId { get; set; }
        public int? WorkFlowTemplateId { get; set; }
        public int? ApntypeCdId { get; set; }

        public virtual TypeCdDmt? ApntypeCd { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
