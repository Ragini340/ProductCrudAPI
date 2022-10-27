using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocTypeDeliveryServer
    {
        public int Id { get; set; }
        public int? DoctypeCdId { get; set; }
        public string? DeliveryServerName { get; set; }
        public int? DeliveryServerId { get; set; }
    }
}
