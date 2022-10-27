using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class HighAvailabilityHeartbeat
    {
        public string ActiveServerFullName { get; set; } = null!;
        public string SourceLibraryFullName { get; set; } = null!;
        public DateTime LastHeartbeatDateTime { get; set; }
        public string? WindowsServiceName { get; set; }
        public int? RequestInProcess { get; set; }
        public DateTime RequestTimeOut { get; set; }
    }
}
