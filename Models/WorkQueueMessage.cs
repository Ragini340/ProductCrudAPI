using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueMessage
    {
        public long WorkQueueMessageId { get; set; }
        public int WorkQueueId { get; set; }
        public int StatusCd { get; set; }
        public string ServerName { get; set; } = null!;
        public string FolderName { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public int UserCreated { get; set; }
        public DateTime DateTimeIn { get; set; }
        public int WorkQueueSourceTypeCdId { get; set; }
        public int? LastUpdUser { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public string? SourceInfo { get; set; }
        public string? MessageInfo { get; set; }
        public int? TotalPages { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public byte? Priority { get; set; }
        public long? WorkQueueEmailBodyId { get; set; }
        public bool? IncludeEmail { get; set; }

        public virtual Employee? LastUpdUserNavigation { get; set; }
        public virtual Employee UserCreatedNavigation { get; set; } = null!;
        public virtual WorkQueue WorkQueue { get; set; } = null!;
        public virtual WorkQueueEmailBody? WorkQueueEmailBody { get; set; }
        public virtual TypeCdDmt WorkQueueSourceTypeCd { get; set; } = null!;
    }
}
