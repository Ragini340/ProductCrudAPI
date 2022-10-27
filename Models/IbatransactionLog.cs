using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbatransactionLog
    {
        public int IbatransactionId { get; set; }
        public byte? Processed { get; set; }
        public Guid? UpdatedKey { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual Ibatransaction Ibatransaction { get; set; } = null!;
    }
}
