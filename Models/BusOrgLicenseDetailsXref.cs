using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgLicenseDetailsXref
    {
        public int BusOrgId { get; set; }
        public int? LicenseTypeCdid { get; set; }
        public string? LicenseNumber { get; set; }
        public int BusOrgLicenseDetailsXrefId { get; set; }

        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual TypeCdDmt? LicenseTypeCd { get; set; }
    }
}
