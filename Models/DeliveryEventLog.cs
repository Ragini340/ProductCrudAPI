using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DeliveryEventLog
    {
        public DeliveryEventLog()
        {
            Documents = new HashSet<Document>();
            EcheckDetails = new HashSet<EcheckDetail>();
            HudDeliveryVersionings = new HashSet<HudDeliveryVersioning>();
        }

        public long DeliveryEventLogId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int EventId { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public int? StatusCd { get; set; }
        public string? DocDeliveryId { get; set; }
        public string? Comments { get; set; }
        public string? ApplContext { get; set; }
        public string? ErrorMsg { get; set; }
        public int UserId { get; set; }
        public int DeliveryMethodTypeCd { get; set; }
        public int? ApplContextTypeCdId { get; set; }
        public string? Iisserver { get; set; }
        public string? DeliveryServer { get; set; }
        public string? Sender { get; set; }
        public string? Recipients { get; set; }
        public int? DocumentFormatTypeCd { get; set; }
        public int? DocumentCount { get; set; }
        public string? DeliveryDocuments { get; set; }
        public int? DeliverySize { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Event Event { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<EcheckDetail> EcheckDetails { get; set; }
        public virtual ICollection<HudDeliveryVersioning> HudDeliveryVersionings { get; set; }
    }
}
