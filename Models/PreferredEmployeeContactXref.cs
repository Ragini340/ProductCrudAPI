using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PreferredEmployeeContactXref
    {
        public int ServiceTypeCdId { get; set; }
        public int BusOrgId { get; set; }
        public int EmployeeId { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
    }
}
