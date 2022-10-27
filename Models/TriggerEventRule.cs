using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TriggerEventRule
    {
        public TriggerEventRule()
        {
            TaskTemplateTriggerEventRuleXrefs = new HashSet<TaskTemplateTriggerEventRuleXref>();
            TaskTemplates = new HashSet<TaskTemplate>();
        }

        public int TriggerEventRuleId { get; set; }
        public int BusinessUnitId { get; set; }
        public int? TriggerEventId { get; set; }
        public string? RuleText { get; set; }

        public virtual ICollection<TaskTemplateTriggerEventRuleXref> TaskTemplateTriggerEventRuleXrefs { get; set; }
        public virtual ICollection<TaskTemplate> TaskTemplates { get; set; }
    }
}
