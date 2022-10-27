using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationTemplateSenderInfoXref
    {
        public int NotificationTemplateSenderInfoXrefId { get; set; }
        public int NotificationTemplateId { get; set; }
        public int? SenderInfoId { get; set; }
        public string? SenderName { get; set; }
        public string? SenderEmailId { get; set; }
        public byte PrecedenceOrder { get; set; }

        public virtual NotificationTemplate NotificationTemplate { get; set; } = null!;
        public virtual TypeCdDmt? SenderInfo { get; set; }
    }
}
