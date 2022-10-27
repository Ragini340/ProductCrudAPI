using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueue
    {
        public WorkQueue()
        {
            WorkQueueEmailBodies = new HashSet<WorkQueueEmailBody>();
            WorkQueueMessageLogs = new HashSet<WorkQueueMessageLog>();
            WorkQueueMessages = new HashSet<WorkQueueMessage>();
            WorkQueueTriggerXrefs = new HashSet<WorkQueueTriggerXref>();
            WorkQueueTypes = new HashSet<WorkQueueType>();
            WorkQueueUserXrefs = new HashSet<WorkQueueUserXref>();
            BusinessUnits = new HashSet<BusinessUnit>();
        }

        public int WorkQueueId { get; set; }
        public string? QueueName { get; set; }
        public string? ServerName { get; set; }
        public string? FolderName { get; set; }
        public short? RetainDeletedDays { get; set; }
        public short SkipQueueMessage { get; set; }
        public short TifannotationFlag { get; set; }
        public string? Comments { get; set; }
        public byte[]? UpdTs { get; set; }
        public byte StatusCd { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? WorkQserver { get; set; }
        public short? LoadBalanceFlag { get; set; }

        public virtual ICollection<WorkQueueEmailBody> WorkQueueEmailBodies { get; set; }
        public virtual ICollection<WorkQueueMessageLog> WorkQueueMessageLogs { get; set; }
        public virtual ICollection<WorkQueueMessage> WorkQueueMessages { get; set; }
        public virtual ICollection<WorkQueueTriggerXref> WorkQueueTriggerXrefs { get; set; }
        public virtual ICollection<WorkQueueType> WorkQueueTypes { get; set; }
        public virtual ICollection<WorkQueueUserXref> WorkQueueUserXrefs { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
    }
}
