using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class MsmqTrace
    {
        public int MsmqTraceId { get; set; }
        public string MsmqMessage { get; set; } = null!;
        public string ServerName { get; set; } = null!;
        public string? QueueName { get; set; }
        public string? EncryptOrDecrypt { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
    }
}
