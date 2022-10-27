using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContactRoleXref
    {
        public int BusOrgContactRoleXrefId { get; set; }
        public int ContactId { get; set; }
        public int RoleTypeCdId { get; set; }
        public short? IsPrimaryFlag { get; set; }

        public virtual BusOrgContact Contact { get; set; } = null!;
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
    }
}
