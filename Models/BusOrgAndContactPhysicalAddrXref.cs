using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgAndContactPhysicalAddrXref
    {
        public int PhysicalAddrXrefId { get; set; }
        public int PhysicalAddrId { get; set; }
        public int OriginalPhysicalAddrId { get; set; }

        public virtual PhysicalAddr OriginalPhysicalAddr { get; set; } = null!;
        public virtual PhysicalAddr PhysicalAddr { get; set; } = null!;
    }
}
