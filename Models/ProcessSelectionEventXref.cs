using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProcessSelectionEventXref
    {
        public int WorkflowTemplateId { get; set; }
        public int TriggerEventTypeCdid { get; set; }
        public int? TriggerEventRuleId { get; set; }
    }
}
