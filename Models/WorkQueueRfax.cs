using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueRfax
    {
        public int WorkQueueRfaxId { get; set; }
        public int? WorkQueueTypeId { get; set; }
        public string FaxNumber { get; set; } = null!;
        public byte StatusCd { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual WorkQueueType? WorkQueueType { get; set; }
    }
}
