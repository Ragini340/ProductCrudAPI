using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ExternalBusinessUnitXref
    {
        public int ExternalApplId { get; set; }
        public int BusinessUnitId { get; set; }
        public string ExternalBusinessUnitNum { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Application ExternalAppl { get; set; } = null!;
    }
}
