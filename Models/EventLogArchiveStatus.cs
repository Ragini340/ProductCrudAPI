using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EventLogArchiveStatus
    {
        public int FileId { get; set; }
        public int EventLogTypeId { get; set; }
        public DateTime? ArchiveStartDateTime { get; set; }
        public DateTime? ArchiveEndDateTime { get; set; }
    }
}
