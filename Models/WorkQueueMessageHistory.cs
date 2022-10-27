using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueMessageHistory
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
    }
}
