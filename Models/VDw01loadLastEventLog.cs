using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadLastEventLog
    {
        public long EventLogId { get; set; }
        public int? FileId { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public string? EventLogComments { get; set; }
        public int? EventSourceId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; } = null!;
        public string? EventComments { get; set; }
        public int? EmployeeId { get; set; }
        public string? LastEvent { get; set; }
    }
}
