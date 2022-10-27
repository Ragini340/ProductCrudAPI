using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProductTypeBusUnitXref
    {
        public int ProductTypeCdId { get; set; }
        public int BusinessUnitId { get; set; }
        public short DefaultFlag { get; set; }
        public short SeqNum { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual TypeCdDmt ProductTypeCd { get; set; } = null!;
    }
}
