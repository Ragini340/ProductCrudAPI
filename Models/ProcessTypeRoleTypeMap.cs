using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProcessTypeRoleTypeMap
    {
        public int ProcessTypeRoleTypeId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public int? ProcessTypeCdId { get; set; }
        public int DisplayOrderSeqNum { get; set; }

        public virtual TypeCdDmt? ProcessTypeCd { get; set; }
        public virtual TypeCdDmt? RoleTypeCd { get; set; }
    }
}
