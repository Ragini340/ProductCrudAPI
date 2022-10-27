using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ApplicationMaintAudit
    {
        public int ApplMaintAuditId { get; set; }
        public string LoginName { get; set; } = null!;
        public DateTime AuditDate { get; set; }
        public string? AuditLog { get; set; }
    }
}
