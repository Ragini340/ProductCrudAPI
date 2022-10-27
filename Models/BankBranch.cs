using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BankBranch
    {
        public BankBranch()
        {
            AlternateBankChangeHistories = new HashSet<AlternateBankChangeHistory>();
            BankAccounts = new HashSet<BankAccount>();
        }

        public int BankId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int AddrBookEntryId { get; set; }
        public string? FastBankCd { get; set; }
        public string? SmsbankCd { get; set; }
        public string? RoutingNum { get; set; }
        public int? AccountNum2SeqNum { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? BankRoutingNumSeqNum { get; set; }
        public int? AccountNumSeqNum { get; set; }
        public string? WireInfo { get; set; }
        public string? BankBranchNum { get; set; }
        public int CheckTemplateId { get; set; }
        public short? BistroWireInterfaceFlag { get; set; }
        public int? PaperSizeTypeCdId { get; set; }
        public bool? AlternateBankFlag { get; set; }
        public byte? WireRoutingMethodCd { get; set; }
        public bool? ApprovedFlag { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<AlternateBankChangeHistory> AlternateBankChangeHistories { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
    }
}
