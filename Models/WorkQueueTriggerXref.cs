using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueTriggerXref
    {
        public int WorkQueueId { get; set; }
        public int BusinessUnitId { get; set; }
        public int WorkQueueTriggerId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual WorkQueue WorkQueue { get; set; } = null!;
        public virtual WorkQueueTrigger WorkQueueTrigger { get; set; } = null!;
    }
}
