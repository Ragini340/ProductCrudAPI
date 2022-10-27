using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbatransactionAdjustmentLog
    {
        public int IbatransactionAdjustmentLogId { get; set; }
        public int IbatransactionId { get; set; }
        public int StatusCdId { get; set; }
        public decimal TransAmount { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime CreationDate { get; set; }
        public string? StatusChgComments { get; set; }
        public int? ExtractId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Employee CreationEmployee { get; set; } = null!;
        public virtual Ibatransaction Ibatransaction { get; set; } = null!;
    }
}
