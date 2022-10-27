using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationEventLog
    {
        public long NotificationEventLogId { get; set; }
        public int FileId { get; set; }
        public int NotificationTemplateId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public byte? StatusCd { get; set; }
        public string? Comments { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int? RegionId { get; set; }
        public int? BusinessUnitId { get; set; }
        public long? DeliveryEventLogId { get; set; }
        public long NotificationEventLogId2 { get; set; }
        public byte[] UpdTs { get; set; } = null!;
    }
}
