using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DepositList
    {
        public DepositList()
        {
            InEscrowDeposits = new HashSet<InEscrowDeposit>();
        }

        public int DepositListId { get; set; }
        public string? DepositListNum { get; set; }
        public int BusinessUnitId { get; set; }
        public int BankAcctId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public int? ExtractId { get; set; }
        public decimal? DepositTotal { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public int DepositListStatusTypecdId { get; set; }
        public int? NumberOfReceipts { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BankAccount BankAcct { get; set; } = null!;
        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual TypeCdDmt DepositListStatusTypecd { get; set; } = null!;
        public virtual Trust32Extract? Extract { get; set; }
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDeposits { get; set; }
    }
}
