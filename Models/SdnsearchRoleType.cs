using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SdnsearchRoleType
    {
        public int SdnsearchRoleTypeId { get; set; }
        public int SdntrackingId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public string? RoleName { get; set; }
        public int? SeqNo { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int? ReferenceId { get; set; }
        public int? ReferenceClassTypeId { get; set; }

        public virtual Sdntracking Sdntracking { get; set; } = null!;
    }
}
