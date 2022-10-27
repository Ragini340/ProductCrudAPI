using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ArchiveTracking
    {
        public int ArchiveTrackingId { get; set; }
        public int? FileId { get; set; }
        public string ArchiveDatabase { get; set; } = null!;
        public DateTime ArchiveDate { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ServiceFile? File { get; set; }
    }
}
