using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CopyDocsRequestHistory
    {
        public int CopyDocsRequestId { get; set; }
        public DateTime RequestStartTime { get; set; }
        public DateTime RequestEndTime { get; set; }
        public int CopyDocsRequestHistoryId { get; set; }
    }
}
