using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EtlsolrfailQueue
    {
        public int EtlsolrfailQueueId { get; set; }
        public int? Id { get; set; }
        public int? EtlsolrId { get; set; }
        public int? Status { get; set; }
        public DateTime? FailTime { get; set; }
        public string? Error { get; set; }

        public virtual Etlsolr? Etlsolr { get; set; }
    }
}
