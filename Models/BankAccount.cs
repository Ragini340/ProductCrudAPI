using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            DepositLists = new HashSet<DepositList>();
            Disbursements = new HashSet<Disbursement>();
            IbabankAccounts = new HashSet<IbabankAccount>();
            InEscrowDeposits = new HashSet<InEscrowDeposit>();
            ServiceFileReverseAccounts = new HashSet<ServiceFileReverseAccount>();
            BusinessUnits = new HashSet<BusinessUnit>();
        }

        public int BankAcctId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public string? AccountNum { get; set; }
        public string? FormattedAcctNum { get; set; }
        public int BankId { get; set; }
        public string? AccountDescr { get; set; }
        public short? DisburseAcctFlag { get; set; }
        public short? DepositAcctFlag { get; set; }
        public short? NumSignatureReq { get; set; }
        public decimal? TwoSignatureReqAmt { get; set; }
        public string? SignatureText { get; set; }
        public short? ActiveStatusCd { get; set; }
        public DateTime? StatusUpdatedDate { get; set; }
        public int? StatusUpdatedEmployeeId { get; set; }
        public string? Signature1 { get; set; }
        public string? Signature2 { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? AccountNum2 { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public string? SignatureText2 { get; set; }
        public short? BistroWireAcctFlag { get; set; }
        public string? AccountNumHmac { get; set; }

        public virtual BankBranch Bank { get; set; } = null!;
        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<DepositList> DepositLists { get; set; }
        public virtual ICollection<Disbursement> Disbursements { get; set; }
        public virtual ICollection<IbabankAccount> IbabankAccounts { get; set; }
        public virtual ICollection<InEscrowDeposit> InEscrowDeposits { get; set; }
        public virtual ICollection<ServiceFileReverseAccount> ServiceFileReverseAccounts { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
    }
}
