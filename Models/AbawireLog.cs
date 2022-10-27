using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AbawireLog
    {
        public int AbawireLogId { get; set; }
        public int Records { get; set; }
        public DateTime JobLastRun { get; set; }
        public bool JobStatus { get; set; }
        public string? Description { get; set; }
    }
}
