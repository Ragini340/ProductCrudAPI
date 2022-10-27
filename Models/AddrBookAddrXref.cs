using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AddrBookAddrXref
    {
        public int PhysicalAddrTypeCdId { get; set; }
        public int AddrBookEntryId { get; set; }
        public int PhysicalAddrId { get; set; }
        public int? BuyerSellerAddressTypeCdId { get; set; }

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
        public virtual PhysicalAddr PhysicalAddr { get; set; } = null!;
        public virtual TypeCdDmt PhysicalAddrTypeCd { get; set; } = null!;
    }
}
