using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RelsTitleDocsAllCopy
    {
        public int FileId { get; set; }
        public int DocId { get; set; }
        public string DocName { get; set; } = null!;
        public string FileNum { get; set; } = null!;
        public int OwnerOfficeId { get; set; }
        public int? SuperbusinessUnitId { get; set; }
        public int? DocTypeCdId { get; set; }
        public short Status { get; set; }
        public string? Path { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Guid? BatchId { get; set; }
    }
}
