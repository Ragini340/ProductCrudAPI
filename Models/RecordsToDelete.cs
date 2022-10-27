using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RecordsToDelete
    {
        public int? TableId { get; set; }
        public long? RowId { get; set; }
        public int RecordsToDeleteId { get; set; }
        public int? FileId { get; set; }
    }
}
