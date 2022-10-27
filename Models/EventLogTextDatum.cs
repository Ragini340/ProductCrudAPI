using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EventLogTextDatum
    {
        public long EventLogId { get; set; }
        public string Comments { get; set; } = null!;
        public int GroupTag { get; set; }
        public int EventLogTextDataId { get; set; }
    }
}
