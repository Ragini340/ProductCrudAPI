using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EventLogEligibleFileId
    {
        public int FileId { get; set; }
        public byte IsProcessed { get; set; }
    }
}
