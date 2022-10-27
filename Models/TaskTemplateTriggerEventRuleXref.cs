using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaskTemplateTriggerEventRuleXref
    {
        public int TaskTemplateId { get; set; }
        public int? TaskEventRuleId { get; set; }
        public int? TaskEventStatusCd { get; set; }
        public short SeqNum { get; set; }
        public int TaskTemplateTriggerEventRuleXrefId { get; set; }

        public virtual TriggerEventRule? TaskEventRule { get; set; }
        public virtual TaskTemplate TaskTemplate { get; set; } = null!;
    }
}
