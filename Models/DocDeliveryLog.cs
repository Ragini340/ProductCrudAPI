using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocDeliveryLog
    {
        public int DocDeliveryLogId { get; set; }
        public long DeliveryEventLogId { get; set; }
        public DateTime ReceivedTime { get; set; }
        public long? DocumentSize { get; set; }
        public long? DrscopyTime { get; set; }
        public DateTime? EndRenderTime { get; set; }
    }
}
