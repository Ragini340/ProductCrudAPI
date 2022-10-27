using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueTrigger
    {
        public WorkQueueTrigger()
        {
            CustomerOptionDocumentTemplates = new HashSet<CustomerOptionDocumentTemplate>();
            NotificationDocumentTemplates = new HashSet<NotificationDocumentTemplate>();
            WorkQueueTriggerXrefs = new HashSet<WorkQueueTriggerXref>();
        }

        public int WorkQueueTriggerId { get; set; }
        public string Name { get; set; } = null!;
        public int BusinessUnitId { get; set; }
        public int StatusCd { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ICollection<CustomerOptionDocumentTemplate> CustomerOptionDocumentTemplates { get; set; }
        public virtual ICollection<NotificationDocumentTemplate> NotificationDocumentTemplates { get; set; }
        public virtual ICollection<WorkQueueTriggerXref> WorkQueueTriggerXrefs { get; set; }
    }
}
