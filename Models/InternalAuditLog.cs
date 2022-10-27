using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InternalAuditLog
    {
        public int InternalAuditLogId { get; set; }
        public int FileId { get; set; }
        public int DocumentTypeCdId { get; set; }
        public string? DocumentName { get; set; }
        public int EventTypeCdId { get; set; }
        public string? AuditDataXml { get; set; }
        public int Version { get; set; }
        public string? ReferenceId { get; set; }
        public int AppId { get; set; }
        public DateTime LogDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? ServerIpaddress { get; set; }
        public string? Comments { get; set; }

        public virtual Application App { get; set; } = null!;
        public virtual DocTypeDmt DocumentTypeCd { get; set; } = null!;
        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
    }
}
