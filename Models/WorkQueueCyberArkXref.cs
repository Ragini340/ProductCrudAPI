using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueCyberArkXref
    {
        public int WorkQueuecyberArkXrefId { get; set; }
        public int? WorkQueueCyberArkId { get; set; }
        public int? WorkQueueTypeId { get; set; }
        public string EmailAddr { get; set; } = null!;
        public string ObjectName { get; set; } = null!;
        public DateTime? LastUpdated { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? ResetIntervalDay { get; set; }
        public string? CredContent { get; set; }

        public virtual WorkQueueCyberArk? WorkQueueCyberArk { get; set; }
        public virtual WorkQueueType? WorkQueueType { get; set; }
    }
}
