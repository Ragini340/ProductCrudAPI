using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AlternateBankChangeHistory
    {
        public int AbchangeHistoryId { get; set; }
        public int BankId { get; set; }
        public int? EmployeeId { get; set; }
        public string? EventDetails { get; set; }
        public DateTime EventDate { get; set; }
        public bool IsApproved { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BankBranch Bank { get; set; } = null!;
        public virtual Employee? Employee { get; set; }
    }
}
