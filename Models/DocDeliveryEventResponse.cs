using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocDeliveryEventResponse
    {
        public long DeliveryEventLogId { get; set; }
        public int FileId { get; set; }
        public string ResponseData { get; set; } = null!;
        public DateTime CreationDate { get; set; }
    }
}
