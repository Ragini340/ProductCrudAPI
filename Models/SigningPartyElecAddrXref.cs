using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SigningPartyElecAddrXref
    {
        public int SigningPartyId { get; set; }
        public int ElecAddrTypeCdId { get; set; }
        public int ElectronicAddrId { get; set; }

        public virtual TypeCdDmt ElecAddrTypeCd { get; set; } = null!;
        public virtual ElectronicAddr ElectronicAddr { get; set; } = null!;
        public virtual SigningParty SigningParty { get; set; } = null!;
    }
}
