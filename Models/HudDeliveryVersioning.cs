using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class HudDeliveryVersioning
    {
        public int VersionNo { get; set; }
        public long DeliveryEventLogId { get; set; }
        public int? FileId { get; set; }
        public string? DocName { get; set; }
        public int SourceRefText { get; set; }
        public int EventMsgId { get; set; }
        public int UserId { get; set; }

        public virtual DeliveryEventLog? DeliveryEventLog { get; set; }
        public virtual ServiceFile? File { get; set; }
        public virtual Employee User { get; set; } = null!;
    }
}
