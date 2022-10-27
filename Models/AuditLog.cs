using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AuditLog
    {
        public Guid AuditLogId { get; set; }
        public int AuditTypeId { get; set; }
        public string TableName { get; set; } = null!;
        public string? PrimaryKey { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
