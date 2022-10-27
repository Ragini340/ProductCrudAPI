using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationChangeHistory
    {
        public int NotificationHistoryId { get; set; }
        public int NotificationTemplateId { get; set; }
        public int EventTypeCdId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
