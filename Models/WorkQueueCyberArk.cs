using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueCyberArk
    {
        public WorkQueueCyberArk()
        {
            WorkQueueCyberArkXrefs = new HashSet<WorkQueueCyberArkXref>();
        }

        public int WorkQueueCyberArkId { get; set; }
        public string SafeName { get; set; } = null!;
        public string RootName { get; set; } = null!;
        public string HostName { get; set; } = null!;
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? AppName { get; set; }

        public virtual ICollection<WorkQueueCyberArkXref> WorkQueueCyberArkXrefs { get; set; }
    }
}
