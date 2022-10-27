using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbatransactionOldBankXref
    {
        public int IbatransactionOldBankXrefId { get; set; }
        public int IbatransactionId { get; set; }
        public string? AccountNum { get; set; }
        public string? FormattedAcctNum { get; set; }
        public string? AccountNumHmac { get; set; }
        public int IbabankId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public decimal? BalanceAmount { get; set; }
        public string? OldBeneficiaryType { get; set; }
        public string? OldBeneficiaryAddress { get; set; }
        public string? OldBeneficiaryName { get; set; }
        public string? OldBeneficiaryRole { get; set; }
        public string? OldBenficiarySsntinflag { get; set; }
        public string? OldIbatype { get; set; }

        public virtual IbabankBranch Ibabank { get; set; } = null!;
        public virtual Ibatransaction Ibatransaction { get; set; } = null!;
    }
}
