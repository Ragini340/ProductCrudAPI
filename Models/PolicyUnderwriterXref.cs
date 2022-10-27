using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PolicyUnderwriterXref
    {
        public int OfficeUnderwriterId { get; set; }
        public string PolicyNumber { get; set; } = null!;
        public int RegionUnderwriterId { get; set; }
        public DateTime? PolicyIssueDate { get; set; }
        public int DocId { get; set; }
        public int? AgentNetPolicyNumberId { get; set; }
        public int FileId { get; set; }

        public virtual AgentNetPolicyNumber? AgentNetPolicyNumber { get; set; }
        public virtual Document Document { get; set; } = null!;
        public virtual OfficeUnderwriter OfficeUnderwriter { get; set; } = null!;
        public virtual RegionUnderwriter RegionUnderwriter { get; set; } = null!;
    }
}
