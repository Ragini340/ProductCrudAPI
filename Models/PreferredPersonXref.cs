using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PreferredPersonXref
    {
        public int ServiceTypeCdId { get; set; }
        public int PersonId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
    }
}
