using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueSummary
    {
        public int WorkQueueId { get; set; }
        public long? WaitingMessages { get; set; }
        public short SkipQueueMessage { get; set; }
        public short TifannotationFlag { get; set; }
    }
}
