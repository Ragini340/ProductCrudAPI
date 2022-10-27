using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PolicyUnderWriterXrefDocprep
    {
        public int OfficeUnderwriterId { get; set; }
        public string PolicyNumber { get; set; } = null!;
        public int RegionUnderwriterId { get; set; }
        public DateTime? PolicyIssueDate { get; set; }
        public long DocId { get; set; }
        public int? AgentNetPolicyNumberId { get; set; }

        public virtual ServiceFileDocumentXref Doc { get; set; } = null!;
        public virtual OfficeUnderwriter OfficeUnderwriter { get; set; } = null!;
        public virtual RegionUnderwriter RegionUnderwriter { get; set; } = null!;
    }
}
