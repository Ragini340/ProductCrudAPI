using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ReserveFileUsed
    {
        public string ReservedFileNumber { get; set; } = null!;
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public int RegionId { get; set; }
        public DateTime ReservedDate { get; set; }
        public string? Comments { get; set; }
        public int UsedBy { get; set; }
        public DateTime UsedDate { get; set; }

        public virtual Employee UsedByNavigation { get; set; } = null!;
    }
}
