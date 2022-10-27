using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PolicyUnderWriterXrefDocprepInsert
    {
        public int OfficeUnderwriterId { get; set; }
        public string PolicyNumber { get; set; } = null!;
        public int RegionUnderwriterId { get; set; }
        public DateTime? PolicyIssueDate { get; set; }
        public long DocId { get; set; }
        public int? AgentNetPolicyNumberId { get; set; }
    }
}
