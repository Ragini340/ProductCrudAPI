using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadEvent
    {
        public int EventId { get; set; }
        public string EventTypeName { get; set; } = null!;
        public int? SuperEventId { get; set; }
        public string Name { get; set; } = null!;
        public short? SeqNum { get; set; }
        public int EventStatusCd { get; set; }
        public string? Comments { get; set; }
    }
}
