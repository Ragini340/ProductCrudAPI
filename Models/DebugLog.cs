using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DebugLog
    {
        public int RowId { get; set; }
        public string StoredProcName { get; set; } = null!;
        public byte? SectionNumber { get; set; }
        public DateTime? SnapshotTime { get; set; }
        public string? DebugInfo { get; set; }
    }
}
