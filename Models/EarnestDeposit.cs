using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EarnestDeposit
    {
        public int EarnestDepositHolderId { get; set; }
        public int ClassTypeId { get; set; }
        public int OutOfEscrowId { get; set; }
        public int HolderEntityTypeCdId { get; set; }
        public string HolderName { get; set; } = null!;
        public decimal EarnestAmount { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt HolderEntityTypeCd { get; set; } = null!;
        public virtual OutOfEscrowDeposit OutOfEscrow { get; set; } = null!;
    }
}
