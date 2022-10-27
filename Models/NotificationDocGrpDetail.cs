using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class NotificationDocGrpDetail
    {
        public int NotificationDocGrpDetailId { get; set; }
        public int NotificationDocGrpId { get; set; }
        public int? NotificationDocumentTemplateId { get; set; }
    }
}
