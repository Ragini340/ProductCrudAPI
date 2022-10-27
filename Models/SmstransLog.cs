using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SmstransLog
    {
        public int RecordClassTypeId { get; set; }
        public int RecordRowId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? ExtractId { get; set; }
        public short? Processed { get; set; }
        public long SmstranslogId { get; set; }
    }
}
