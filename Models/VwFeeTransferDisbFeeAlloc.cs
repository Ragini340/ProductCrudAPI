using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwFeeTransferDisbFeeAlloc
    {
        public int Disbursementid { get; set; }
        public int FeeToBucket { get; set; }
        public decimal AllocationAmount { get; set; }
        public decimal BssalesTaxAmt { get; set; }
    }
}
