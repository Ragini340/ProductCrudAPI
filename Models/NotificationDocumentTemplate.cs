using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationDocumentTemplate
    {
        public int NotificationDocumentTemplateId { get; set; }
        public int NotificationTemplateId { get; set; }
        public int? TemplateId { get; set; }
        public int? WorkQueueTriggerId { get; set; }
        public int NotificationDocTypeCdId { get; set; }
        public int? SeqNum { get; set; }
        public int? Status { get; set; }
        public byte? RequiredYesNo { get; set; }
        public byte? AutoCreate { get; set; }
        public string? DocObjectCd { get; set; }
        public int? TemplateRegionId { get; set; }

        public virtual NotificationTemplate NotificationTemplate { get; set; } = null!;
        public virtual WorkQueueTrigger? WorkQueueTrigger { get; set; }
    }
}
