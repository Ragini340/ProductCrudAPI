using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbabankAccount
    {
        public IbabankAccount()
        {
            Ibatransactions = new HashSet<Ibatransaction>();
        }

        public int IbabankAccountId { get; set; }
        public int IbabankId { get; set; }
        public int FileId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int BeneficiaryTypeCdId { get; set; }
        public byte BeneficiarySpouse { get; set; }
        public byte? OtherBeneficiaryType { get; set; }
        public string? Description { get; set; }
        public string? AccountNum { get; set; }
        public string? FormattedAcctNum { get; set; }
        public string? SeqNum { get; set; }
        public int IbabankTypeCdId { get; set; }
        public int? IbabankProductId { get; set; }
        public string? ProductName { get; set; }
        public string? NonAutoBankContact { get; set; }
        public decimal? Apy { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal? AccruedInterest { get; set; }
        public DateTime? AccruedDate { get; set; }
        public DateTime? AlertDate { get; set; }
        public int? AlertId { get; set; }
        public int? ChargeId { get; set; }
        public byte? StatusCdId { get; set; }
        public DateTime? StatusUpdatedDate { get; set; }
        public int? StatusUpdatedEmployeeId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public string? StatusChgComments { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public short? StatusCd { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? ExtractId { get; set; }
        public string? AccountNumHmac { get; set; }
        public int? FastBankAccountId { get; set; }

        public virtual Charge? Charge { get; set; }
        public virtual Employee? CreationEmployee { get; set; }
        public virtual BankAccount? FastBankAccount { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual IbabankProduct? IbabankProduct { get; set; }
        public virtual TypeCdDmt IbabankTypeCd { get; set; } = null!;
        public virtual ICollection<Ibatransaction> Ibatransactions { get; set; }
    }
}
