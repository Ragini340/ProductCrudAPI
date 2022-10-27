using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SymentecVipauditLog
    {
        public int AuditLogId { get; set; }
        public int UserId { get; set; }
        public string? CredentialId { get; set; }
        public string? RequestId { get; set; }
        public string StatusCode { get; set; } = null!;
        public string StatusMessage { get; set; } = null!;
        public byte[] Updts { get; set; } = null!;

        public virtual Employee User { get; set; } = null!;
    }
}
