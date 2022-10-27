using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PreferredBusOrgContactXref
    {
        public int ServiceTypeCdId { get; set; }
        public int ContactId { get; set; }
        public int EmployeeId { get; set; }

        public virtual BusOrgContact Contact { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
    }
}
