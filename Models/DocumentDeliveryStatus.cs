using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentDeliveryStatus
    {
        public int DocId { get; set; }
        public byte? DeliveredFlag { get; set; }
        public int FileTypeId { get; set; }
    }
}
