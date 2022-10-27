using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EtitleBusinessUnit
    {
        public int BusinessUnitId { get; set; }
        public int CorporateBusOrgId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual CorporateBusOrg CorporateBusOrg { get; set; } = null!;
    }
}
