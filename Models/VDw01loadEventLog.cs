using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadEventLog
    {
        public long EventLogId { get; set; }
        public int? FileId { get; set; }
        public DateTime Dwdate { get; set; }
        public int? EventId { get; set; }
        public long? SuperEventLogId { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int? EventSourceId { get; set; }
        public string EventSourceTypeName { get; set; } = null!;
        public int? StatusCd { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string? Comments { get; set; }
        public string? ApplContext { get; set; }
        public string? ErrorMsg { get; set; }
    }
}
