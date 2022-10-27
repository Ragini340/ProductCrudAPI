using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SigningAddrXref
    {
        public int SigningId { get; set; }
        public int AddrTypeCdId { get; set; }
        public int PhysicalAddrId { get; set; }
        public string? BusinessName { get; set; }
        public int? OfficeId { get; set; }

        public virtual TypeCdDmt AddrTypeCd { get; set; } = null!;
        public virtual BusinessUnit? Office { get; set; }
        public virtual PhysicalAddr PhysicalAddr { get; set; } = null!;
        public virtual Signing Signing { get; set; } = null!;
    }
}
