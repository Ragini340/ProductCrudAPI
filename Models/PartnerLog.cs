using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PartnerLog
    {
        public int PartnerLogId { get; set; }
        public int? FileId { get; set; }
        public int EventTypeCdId { get; set; }
        public string? ExternalEventCode { get; set; }
        public string? ExternalEventDescr { get; set; }
        public string AuditDataXml { get; set; } = null!;
        public int AppId { get; set; }
        public DateTime LogDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Application App { get; set; } = null!;
        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
        public virtual ServiceFile? File { get; set; }
    }
}
