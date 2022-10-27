using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VSmstranslogTbl
    {
        public int? ExtractId { get; set; }
        public long SmstranslogId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int RecordClassTypeId { get; set; }
        public int RecordRowId { get; set; }
        public string? TableName { get; set; }
    }
}
