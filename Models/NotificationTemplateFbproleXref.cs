using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationTemplateFbproleXref
    {
        public int NotificationTemplateFbproleXrefId { get; set; }
        public int NotificationTemplateId { get; set; }
        public int FbproleTypeCdId { get; set; }

        public virtual TypeCdDmt FbproleTypeCd { get; set; } = null!;
        public virtual NotificationTemplate NotificationTemplate { get; set; } = null!;
    }
}
