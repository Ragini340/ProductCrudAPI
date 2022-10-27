using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficesForFastc
    {
        public int BusinessUnitId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
    }
}
