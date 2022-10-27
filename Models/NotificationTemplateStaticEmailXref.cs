using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationTemplateStaticEmailXref
    {
        public int NotificationTemplateStaticEmailXrefId { get; set; }
        public int NotificationTemplateId { get; set; }
        public string Name { get; set; } = null!;
        public string EmailId { get; set; } = null!;

        public virtual NotificationTemplate NotificationTemplate { get; set; } = null!;
    }
}
