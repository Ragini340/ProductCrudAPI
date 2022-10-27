using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbabankStatusChangeXref
    {
        public int IbabankStatusChangeId { get; set; }
        public int IbabankId { get; set; }
        public DateTime? CurrStatusDate { get; set; }
        public short BankStatus { get; set; }
        public int EmployeeId { get; set; }
        public string? Notes { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
        public virtual IbabankBranch Ibabank { get; set; } = null!;
    }
}
