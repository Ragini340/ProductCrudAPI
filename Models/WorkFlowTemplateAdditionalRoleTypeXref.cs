using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateAdditionalRoleTypeXref
    {
        public int WorkFlowTemplateId { get; set; }
        public int? AddlRoleTypeCdId { get; set; }
        public int WorkFlowTemplateAdditionalRoleTypeXrefId { get; set; }

        public virtual TypeCdDmt? AddlRoleTypeCd { get; set; }
        public virtual WorkFlowTemplate WorkFlowTemplate { get; set; } = null!;
    }
}
