using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FastSearchLog
    {
        public int FastSearchLogId { get; set; }
        public int FileId { get; set; }
        public string FastSearchOrderId { get; set; } = null!;
        public int SiteId { get; set; }
        public int? PropertyId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
