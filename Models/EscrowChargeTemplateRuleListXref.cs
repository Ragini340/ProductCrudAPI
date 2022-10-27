using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EscrowChargeTemplateRuleListXref
    {
        public int EscrowChargeTemplateRuleListXrefId { get; set; }
        public int EscrowChargeTemplateId { get; set; }
        public int RuleId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual EscrowChargeTemplate EscrowChargeTemplate { get; set; } = null!;
        public virtual RuleList Rule { get; set; } = null!;
    }
}
