using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileDetailsImageDocTool
    {
        public int FileId { get; set; }
        public int? Fileprocesstatus { get; set; }
        public int? OfficeId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? ImageDocDate { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
