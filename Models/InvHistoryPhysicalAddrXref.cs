using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InvHistoryPhysicalAddrXref
    {
        public int InvoiceHistoryId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public int PhysicalAddrId { get; set; }
        public decimal? FeeAllocationAmount { get; set; }
    }
}
