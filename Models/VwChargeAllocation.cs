using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VwChargeAllocation
    {
        public int PfchargeId { get; set; }
        public int IsFcdollarAllocated { get; set; }
        public int IsBcdollarAllocated { get; set; }
        public int IsBcrdollarAllocated { get; set; }
        public int IsScdollarAllocated { get; set; }
        public int IsScrdollarAllocated { get; set; }
        public int IsSfallocated { get; set; }
    }
}
