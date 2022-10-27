using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PersonRoleRelationshipXref
    {
        public int PersonRelationshipId { get; set; }
        public int RoleTypeCdId { get; set; }
        public short? PrimaryRole { get; set; }
        public int? StatusCd { get; set; }

        public virtual PersonRelationship PersonRelationship { get; set; } = null!;
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
    }
}
