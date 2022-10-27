using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EventLogOe
    {
        public long EventLogId { get; set; }
        public int ClassTypeId { get; set; }
        public int EventSourceClassTypeId { get; set; }
        public int FileId { get; set; }
        public long? SuperEventLogId { get; set; }
        public int EventId { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int EventSourceId { get; set; }
        public int? StatusCd { get; set; }
        public string? DocDeliveryId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public int? UpdSourceId { get; set; }
        public int? UpdSourceClassTypeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? ApplContext { get; set; }
        public string? ErrorMsg { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Event Event { get; set; } = null!;
        public virtual ClassType EventSourceClassType { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual EventLogKey? SuperEventLog { get; set; }
        public virtual ClassType? UpdSourceClassType { get; set; }
    }
}
