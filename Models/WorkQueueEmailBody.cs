using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueEmailBody
    {
        public WorkQueueEmailBody()
        {
            WorkQueueMessages = new HashSet<WorkQueueMessage>();
        }

        public long WorkQueueEmailBodyId { get; set; }
        public int WorkQueueId { get; set; }
        public string FolderName { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public bool HasAttachments { get; set; }
        public int StatusCd { get; set; }
        public string ServerName { get; set; } = null!;
        public int UserCreated { get; set; }
        public DateTime DateTimeIn { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Employee UserCreatedNavigation { get; set; } = null!;
        public virtual WorkQueue WorkQueue { get; set; } = null!;
        public virtual ICollection<WorkQueueMessage> WorkQueueMessages { get; set; }
    }
}
