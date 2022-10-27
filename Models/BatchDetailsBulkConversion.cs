using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BatchDetailsBulkConversion
    {
        public int FileId { get; set; }
        public int? BatchId { get; set; }
        public int? IsProcessed { get; set; }
        public int? IsUpdated { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
