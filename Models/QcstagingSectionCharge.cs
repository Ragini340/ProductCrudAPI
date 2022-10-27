using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class QcstagingSectionCharge
    {
        public int QcstagingSectionChargeId { get; set; }
        public int QcstagingSectionXrefId { get; set; }
        public int QcstagingId { get; set; }
        public int AcceptRejectFlag { get; set; }
        public string? Comments { get; set; }
        public DateTime ProcessedDate { get; set; }
        public int UserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int ChargeId { get; set; }
        public int EscrowChargeTemplateId { get; set; }
        public short IsAdd { get; set; }
        public int? FeeId { get; set; }

        public virtual Qcstaging Qcstaging { get; set; } = null!;
        public virtual QcstagingSectionXref QcstagingSectionXref { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
