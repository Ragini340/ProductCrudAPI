using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceBehaviorLog
    {
        public int Id { get; set; }
        public Guid TrackingId { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; } = null!;
        public string LogLevel { get; set; } = null!;
        public string LoggerName { get; set; } = null!;
        public int ProcessId { get; set; }
        public int ThreadId { get; set; }
        public string Message { get; set; } = null!;
        public string Exception { get; set; } = null!;
        public string ClientIp { get; set; } = null!;
        public string ServerName { get; set; } = null!;
        public string ServerIp { get; set; } = null!;
        public string SoapAction { get; set; } = null!;
        public string RequestResponseType { get; set; } = null!;
    }
}
