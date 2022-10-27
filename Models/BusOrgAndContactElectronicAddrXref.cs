using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgAndContactElectronicAddrXref
    {
        public int ElectronicAddrXrefId { get; set; }
        public int ElectronicAddrId { get; set; }
        public int OriginalElectronicAddrId { get; set; }

        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual ElectronicAddr OriginalElectronicAddr { get; set; } = null!;
    }
}
