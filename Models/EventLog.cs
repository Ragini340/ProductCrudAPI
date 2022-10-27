using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EventLog
    {
        public long EventLogId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? EventSourceClassTypeId { get; set; }
        public int? FileId { get; set; }
        public long? SuperEventLogId { get; set; }
        public int? EventId { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int? EventSourceId { get; set; }
        public int? StatusCd { get; set; }
        public string? DocDeliveryId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int? UpdSourceId { get; set; }
        public int? UpdSourceClassTypeId { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? Comments { get; set; }
        public string? ApplContext { get; set; }
        public string? ErrorMsg { get; set; }
        public int? AssignedToId { get; set; }
    }
}
