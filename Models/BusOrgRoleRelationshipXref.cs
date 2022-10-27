using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgRoleRelationshipXref
    {
        public int BusOrgRelationshipId { get; set; }
        public int RoleTypeCdId { get; set; }
        public short? PrimaryRole { get; set; }
        public int? StatusCd { get; set; }

        public virtual BusOrgRelationship BusOrgRelationship { get; set; } = null!;
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
    }
}
