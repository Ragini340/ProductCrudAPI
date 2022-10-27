using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CheckDisbursement
    {
        public int CheckDisbursementId { get; set; }
        public int ClassTypeId { get; set; }
        public long? EventLogId { get; set; }
        public int DisbursementId { get; set; }
        public string? ErrorMsg { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Disbursement Disbursement { get; set; } = null!;
    }
}
