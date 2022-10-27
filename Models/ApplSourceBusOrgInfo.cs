using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ApplSourceBusOrgInfo
    {
        public int BusOrgId { get; set; }
        public int SourceApplId { get; set; }
        public string SourceApplBusOrgId { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual Application SourceAppl { get; set; } = null!;
    }
}
