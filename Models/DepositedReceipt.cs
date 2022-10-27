using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DepositedReceipt
    {
        public int InEscrowId { get; set; }
        public int? DepositStatusCdId { get; set; }
        public string? ClearedSeqNum { get; set; }
        public DateTime? DepositedDate { get; set; }
        public decimal? DepositAmount { get; set; }
        public string? Fsbflag { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte? StatusCd { get; set; }
        public byte[]? UpdTs { get; set; }

        public virtual TypeCdDmt? DepositStatusCd { get; set; }
        public virtual InEscrowDeposit InEscrow { get; set; } = null!;
    }
}
