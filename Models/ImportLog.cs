using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ImportLog
    {
        public short ImportLogId { get; set; }
        public short? BatchId { get; set; }
        public short? Iteration { get; set; }
        public int? SourceRegionId { get; set; }
        public int? TargetRegionId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? TableName { get; set; }
        public int? SourceRowCount { get; set; }
        public int? TargetRowCount { get; set; }
    }
}
