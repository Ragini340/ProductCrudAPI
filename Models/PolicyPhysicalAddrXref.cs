using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PolicyPhysicalAddrXref
    {
        public int PolicyId { get; set; }
        public int PhysicalAddrId { get; set; }

        public virtual PhysicalAddr PhysicalAddr { get; set; } = null!;
    }
}
