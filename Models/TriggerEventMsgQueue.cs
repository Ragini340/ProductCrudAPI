using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TriggerEventMsgQueue
    {
        public int EventMsqId { get; set; }
        public int? EventId { get; set; }
        public string? EventData { get; set; }
        public int? EventStatus { get; set; }
        public string? EventServer { get; set; }
        public int? Priority { get; set; }
        public byte[]? UpdTs { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public DateTime? ProcessStartTime { get; set; }
        public DateTime? ProcessEndTime { get; set; }
        public string? Comments { get; set; }
    }
}
