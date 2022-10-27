using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EsigningDashboardDetail
    {
        public int EsigningEventLogId { get; set; }
        public long? DeliveryEventLogId { get; set; }
        public int FileId { get; set; }
        public string DocumentName { get; set; } = null!;
        public string EsigningInitiatedBy { get; set; } = null!;
        public DateTime? EsigningInitiatedOn { get; set; }
        public int EsigningStatus { get; set; }
        public int EsigningPlatform { get; set; }
        public DateTime? EsigningCompletedOn { get; set; }
        public int NoOfCompletedDocs { get; set; }

        public virtual TypeCdDmt EsigningPlatformNavigation { get; set; } = null!;
        public virtual TypeCdDmt EsigningStatusNavigation { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
    }
}
