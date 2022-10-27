using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ReserveFile
    {
        public string ReservedFileNumber { get; set; } = null!;
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public int RegionId { get; set; }
        public DateTime ReservedDate { get; set; }
        public string? Comments { get; set; }

        public virtual BusinessUnit Office { get; set; } = null!;
        public virtual BusinessUnit Region { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
