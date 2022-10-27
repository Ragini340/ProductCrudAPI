using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusinessUnitAuditLog
    {
        public int BusinessUnitAuditLogId { get; set; }
        public int BusinessUnitId { get; set; }
        public int UserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int Flsenable { get; set; }
        public string? EntryStatus { get; set; }
        public byte[] Updts { get; set; } = null!;
    }
}
