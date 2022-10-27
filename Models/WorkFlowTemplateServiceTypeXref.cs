using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateServiceTypeXref
    {
        public int WorkFlowTemplateServiceTypeXrefId { get; set; }
        public int? WorkFlowTemplateId { get; set; }
        public int? ServiceTypeCdId { get; set; }

        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
