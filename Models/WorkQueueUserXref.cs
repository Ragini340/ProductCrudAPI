using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueUserXref
    {
        public int WorkQueueId { get; set; }
        public int UserId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? SkipMessage { get; set; }
        public bool? Supervisor { get; set; }

        public virtual Employee User { get; set; } = null!;
        public virtual WorkQueue WorkQueue { get; set; } = null!;
    }
}
