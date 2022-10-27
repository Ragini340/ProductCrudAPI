using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContactRoleRelationshipXref
    {
        public int BusOrgContactRelationshipId { get; set; }
        public int RoleTypeCdId { get; set; }
        public short? PrimaryRole { get; set; }
        public int? StatusCd { get; set; }

        public virtual BusOrgContactRelationship BusOrgContactRelationship { get; set; } = null!;
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
    }
}
