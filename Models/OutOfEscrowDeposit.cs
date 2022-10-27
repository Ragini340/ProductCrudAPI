using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OutOfEscrowDeposit
    {
        public OutOfEscrowDeposit()
        {
            EarnestDeposits = new HashSet<EarnestDeposit>();
        }

        public int OutOfEscrowId { get; set; }
        public int ClassTypeId { get; set; }
        public int FileId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int StatusTypeCdId { get; set; }
        public int SourceTypeCdId { get; set; }
        public decimal Amount { get; set; }
        public decimal ExcessDepositAmount { get; set; }
        public decimal DisbursedAsProceedsAmount { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt SourceTypeCd { get; set; } = null!;
        public virtual TypeCdDmt StatusTypeCd { get; set; } = null!;
        public virtual TypeCdDmt TransactionTypeCd { get; set; } = null!;
        public virtual ICollection<EarnestDeposit> EarnestDeposits { get; set; }
    }
}
