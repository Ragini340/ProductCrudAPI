using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbabankBranchAddrXref
    {
        public int IbabankId { get; set; }
        public int AddrBookEntryId { get; set; }
        public int AddrTypeCdId { get; set; }

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
        public virtual IbabankBranch Ibabank { get; set; } = null!;
    }
}
