using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Etlsolr
    {
        public Etlsolr()
        {
            EtlsolrfailQueues = new HashSet<EtlsolrfailQueue>();
        }

        public int Etlsolrid { get; set; }
        public int? RegionId { get; set; }
        public int? BeginId { get; set; }
        public int? EndId { get; set; }
        public int? EventType { get; set; }
        public int? Status { get; set; }
        public string? EventServer { get; set; }
        public DateTime? ProcessTime { get; set; }
        public DateTime? FailTime { get; set; }
        public string? Error { get; set; }

        public virtual ICollection<EtlsolrfailQueue> EtlsolrfailQueues { get; set; }
    }
}
