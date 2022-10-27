using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AccountingSystem
    {
        public AccountingSystem()
        {
            BusUnitAcctSystemXrefs = new HashSet<BusUnitAcctSystemXref>();
        }

        public int AcctSystemId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDefault { get; set; }
        public string Path { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;
        public bool UseInvoiceExtract { get; set; }
        public bool UseFeeTransferExtract { get; set; }
        public bool UseServiceFeeTransferExtract { get; set; }

        public virtual ICollection<BusUnitAcctSystemXref> BusUnitAcctSystemXrefs { get; set; }
    }
}
