using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplatePropertyTypeXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int? PropertyTypeCdId { get; set; }
        public int WorkFlowTemplatePropertyTypeXrefId { get; set; }
    }
}
