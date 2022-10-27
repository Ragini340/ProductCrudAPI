using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RuleList
    {
        public RuleList()
        {
            EscrowChargeTemplateRuleListXrefs = new HashSet<EscrowChargeTemplateRuleListXref>();
            RuleListBusUnitXrefs = new HashSet<RuleListBusUnitXref>();
        }

        public int RuleId { get; set; }
        public int BusinessUnitId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTill { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public DateTime? DeActivationDate { get; set; }
        public int? DeActivationBy { get; set; }
        public DateTime? ReActivationDate { get; set; }
        public int? ReActivationBy { get; set; }
        public string? RuleXml { get; set; }
        public byte? ApplicableTo { get; set; }
        public int StatusCd { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee? CreatedByNavigation { get; set; }
        public virtual Employee? DeActivationByNavigation { get; set; }
        public virtual Employee? LastUpdatedByNavigation { get; set; }
        public virtual Employee? ReActivationByNavigation { get; set; }
        public virtual ICollection<EscrowChargeTemplateRuleListXref> EscrowChargeTemplateRuleListXrefs { get; set; }
        public virtual ICollection<RuleListBusUnitXref> RuleListBusUnitXrefs { get; set; }
    }
}
