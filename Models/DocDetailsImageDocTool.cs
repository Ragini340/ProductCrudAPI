using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocDetailsImageDocTool
    {
        public int FileId { get; set; }
        public long DocId { get; set; }
        public int? ImageDocStatus { get; set; }
        public int? OfficeId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? ImageDocDate { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
