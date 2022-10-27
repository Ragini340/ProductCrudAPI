using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueMessageLog
    {
        public long WorkQueueMessageLogId { get; set; }
        public long WorkQueueMessageId { get; set; }
        public int WorkQueueId { get; set; }
        public int StatusCd { get; set; }
        public int UserId { get; set; }
        public DateTime LogCreatedDate { get; set; }
        public string? Comments { get; set; }
        public int? FileId { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual Employee User { get; set; } = null!;
        public virtual WorkQueue WorkQueue { get; set; } = null!;
    }
}
