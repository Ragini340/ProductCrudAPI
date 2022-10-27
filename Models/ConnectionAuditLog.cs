using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ConnectionAuditLog
    {
        public DateTime? ConnectTime { get; set; }
        public string? EncryptOption { get; set; }
        public string? HostName { get; set; }
        public string? ProgramName { get; set; }
        public string? LoginName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
