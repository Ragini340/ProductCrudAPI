using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadEvent
    {
        public int EventId { get; set; }
        public string EventTypeName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? SeqNum { get; set; }
        public int EventStatusCd { get; set; }
        public int? SuperEventId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public string? Comments { get; set; }
    }
}
