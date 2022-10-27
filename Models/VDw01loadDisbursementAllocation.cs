using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadDisbursementAllocation
    {
        public int DisbursementAllocationId { get; set; }
        public int TransactionId { get; set; }
        public int TransactionTypeCdId { get; set; }
        public int DisbursementId { get; set; }
        public decimal CheckAmount { get; set; }
        public decimal AllocationAmount { get; set; }
        public string Description { get; set; } = null!;
    }
}
