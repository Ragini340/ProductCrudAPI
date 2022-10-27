using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbabankBranch
    {
        public IbabankBranch()
        {
            IbabankBranchAddrXrefs = new HashSet<IbabankBranchAddrXref>();
            IbabankProducts = new HashSet<IbabankProduct>();
            IbabankStatusChangeXrefs = new HashSet<IbabankStatusChangeXref>();
            IbabankbranchBuxrefs = new HashSet<IbabankbranchBuxref>();
            IbatransactionOldBankXrefs = new HashSet<IbatransactionOldBankXref>();
        }

        public int IbabankId { get; set; }
        public int? BusinessUnitId { get; set; }
        public string AbaroutingNo { get; set; } = null!;
        public DateTime? Cutofftime { get; set; }
        public short? BankStatus { get; set; }
        public byte DefaultBank { get; set; }
        public int? TimeZoneCdId { get; set; }
        public short StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? IsExchangeRegionFlag { get; set; }
        public DateTime? CurrStatusDate { get; set; }
        public int? CurrStatusUserId { get; set; }
        public string? Notes { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual Employee? CreationEmployee { get; set; }
        public virtual Employee? CurrStatusUser { get; set; }
        public virtual TypeCdDmt? TimeZoneCd { get; set; }
        public virtual ICollection<IbabankBranchAddrXref> IbabankBranchAddrXrefs { get; set; }
        public virtual ICollection<IbabankProduct> IbabankProducts { get; set; }
        public virtual ICollection<IbabankStatusChangeXref> IbabankStatusChangeXrefs { get; set; }
        public virtual ICollection<IbabankbranchBuxref> IbabankbranchBuxrefs { get; set; }
        public virtual ICollection<IbatransactionOldBankXref> IbatransactionOldBankXrefs { get; set; }
    }
}
