using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RuleListBusUnitXref
    {
        public int RuleListBusUnitXrefId { get; set; }
        public int RuleId { get; set; }
        public int BusinessUnitId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual RuleList Rule { get; set; } = null!;
    }
}
