using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PerformanceAudit
    {
        public int Id { get; set; }
        public string ActionTrackingId { get; set; } = null!;
        public string? ActionName { get; set; }
        public string? SubActionTrackingId { get; set; }
        public int? SubActionOrder { get; set; }
        public string? SubActionName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan ElapsedTime { get; set; }
    }
}
