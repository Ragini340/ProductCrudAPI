using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateOriginatorXref
    {
        public int WorkFlowOriginatorId { get; set; }
        public int? WorkFlowTemplateId { get; set; }
        public int? OriginatorId { get; set; }
        public int? OriginatorTypeCdId { get; set; }

        public virtual TypeCdDmt? OriginatorTypeCd { get; set; }
        public virtual WorkFlowTemplate? WorkFlowTemplate { get; set; }
    }
}
