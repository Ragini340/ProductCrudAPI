using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueMessageXmldatum
    {
        public int WorkQueueMessageId { get; set; }
        public string? Xmltext { get; set; }
        public byte[]? UpdTs { get; set; }
    }
}
