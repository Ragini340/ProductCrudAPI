using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FractionalSettlementStatement
    {
        public int FractionalSsid { get; set; }
        public int FileId { get; set; }
        public int ChargeId { get; set; }
        public string? ChargeAllocation { get; set; }
        public string? CreditAllocation { get; set; }
        public short? PrincipalTypeCdid { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
    }
}
