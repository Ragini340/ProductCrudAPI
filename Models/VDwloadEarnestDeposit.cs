using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadEarnestDeposit
    {
        public int EarnestDepositHolderId { get; set; }
        public string ClassTypeDescr { get; set; } = null!;
        public int OutOfEscrowId { get; set; }
        public int HolderEntityTypeCdId { get; set; }
        public string HolderName { get; set; } = null!;
        public decimal EarnestAmount { get; set; }
    }
}
