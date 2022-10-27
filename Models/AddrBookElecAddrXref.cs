using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AddrBookElecAddrXref
    {
        public int ElectronicAddrTypeCdId { get; set; }
        public int AddrBookEntryId { get; set; }
        public int ElectronicAddrId { get; set; }

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual TypeCdDmt ElectronicAddrTypeCd { get; set; } = null!;
    }
}
