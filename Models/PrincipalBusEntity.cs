using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PrincipalBusEntity
    {
        public PrincipalBusEntity()
        {
            AuthSignatures = new HashSet<AuthSignature>();
        }

        public int PrincipalBusEntityById { get; set; }
        public int ClassTypeId { get; set; }
        public int PrincipalId { get; set; }
        public int? OrgTypeCdId { get; set; }
        public int? StateOfIncGeoRegionId { get; set; }
        public string? Name { get; set; }
        public string? ContactName { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? EntitySign { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt? OrgTypeCd { get; set; }
        public virtual Principal Principal { get; set; } = null!;
        public virtual GeographicRegion? StateOfIncGeoRegion { get; set; }

        public virtual ICollection<AuthSignature> AuthSignatures { get; set; }
    }
}
