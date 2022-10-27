using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EfileRoleTypeXref
    {
        public long ServiceFileEfileXrefId { get; set; }
        public int RoleTypeCdId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? FileBusinessPartyId { get; set; }
        public int EfileRoleTypeXrefId { get; set; }

        public virtual ServiceFileEfileXref ServiceFileEfileXref { get; set; } = null!;
    }
}
