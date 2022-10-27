using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusUnitAcctSystemXref
    {
        public int BusinessUnitId { get; set; }
        public int AcctSystemId { get; set; }

        public virtual AccountingSystem AcctSystem { get; set; } = null!;
        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
    }
}
