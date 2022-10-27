using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class MdmbusinessEventLogHistory
    {
        public long? MdmbusinessEventLogId { get; set; }
        public long? ParentEntepriseId { get; set; }
        public long? RecordEntepriseId { get; set; }
        public string? BusinessEventName { get; set; }
        public string? Xmlmessage { get; set; }
        public DateTime? LogDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? StatusCd { get; set; }
        public string? SatusComment { get; set; }
        public DateTime? QueuePickDateTime { get; set; }
        public DateTime? LastUpdationDateTime { get; set; }
    }
}
