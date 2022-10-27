using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkQueueType
    {
        public WorkQueueType()
        {
            WorkQueueCyberArkXrefs = new HashSet<WorkQueueCyberArkXref>();
            WorkQueueRfaxes = new HashSet<WorkQueueRfax>();
        }

        public int WorkQueueTypeId { get; set; }
        public int WorkQueueId { get; set; }
        public int WorkQueueTypeCdId { get; set; }
        public string? OtherDetails { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? ReceiverData { get; set; }
        public short? StatusCd { get; set; }
        public short? TiffConversion { get; set; }
        public DateTime? LastMsgDate { get; set; }

        public virtual WorkQueue WorkQueue { get; set; } = null!;
        public virtual TypeCdDmt WorkQueueTypeCd { get; set; } = null!;
        public virtual ICollection<WorkQueueCyberArkXref> WorkQueueCyberArkXrefs { get; set; }
        public virtual ICollection<WorkQueueRfax> WorkQueueRfaxes { get; set; }
    }
}
