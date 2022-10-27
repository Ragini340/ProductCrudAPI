using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentDelivery
    {
        public int JobId { get; set; }
        public long EventLogId { get; set; }
        public string DocDeliveryMethod { get; set; } = null!;
        public string DocDeliveryMessage { get; set; } = null!;
        public string DocDeliveryStatus { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? EnvironmentName { get; set; }
    }
}
