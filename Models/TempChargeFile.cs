using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TempChargeFile
    {
        public int FileId { get; set; }
        public int TempChargeFileId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
