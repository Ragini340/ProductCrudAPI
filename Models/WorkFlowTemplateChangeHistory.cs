using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkFlowTemplateChangeHistory
    {
        public int WorkFlowTemplateHistoryId { get; set; }
        public int WorkFlowTemplateId { get; set; }
        public int EventTypeCdId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Notes { get; set; }

        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
        public virtual WorkFlowTemplate WorkFlowTemplate { get; set; } = null!;
    }
}
