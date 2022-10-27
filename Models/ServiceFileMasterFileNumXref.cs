using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileMasterFileNumXref
    {
        public int FileId { get; set; }
        public string? MasterFileNumber { get; set; }
        public string? Notes { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
