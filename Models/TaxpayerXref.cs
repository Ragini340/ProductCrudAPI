using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaxpayerXref
    {
        public int FileBusinessPartyId { get; set; }
        public short? W8flag { get; set; }
        public short? W8flagSpouse { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
    }
}
