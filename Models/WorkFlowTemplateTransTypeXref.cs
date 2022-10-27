using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateTransTypeXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int? TransTypeCdId { get; set; }
        public int WorkFlowTemplateTransTypeXrefId { get; set; }
    }
}
