using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LicenseTypeGeoRegionXref
    {
        public LicenseTypeGeoRegionXref()
        {
            LicenseInformations = new HashSet<LicenseInformation>();
        }

        public int LicenseTypeGeoRegionXrefId { get; set; }
        public int LicenseTypeId { get; set; }
        public int StatusCd { get; set; }
        public int? GeoRegionId { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public int? DeactivationUserId { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? ReactivationUserId { get; set; }
        public string? Comments { get; set; }
        public int? LicenseTypeCategoryTypeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Employee CreationUser { get; set; } = null!;
        public virtual Employee? DeactivationUser { get; set; }
        public virtual GeographicRegion? GeoRegion { get; set; }
        public virtual LicenseType LicenseType { get; set; } = null!;
        public virtual TypeCdDmt? LicenseTypeCategoryType { get; set; }
        public virtual Employee? ReactivationUser { get; set; }
        public virtual ICollection<LicenseInformation> LicenseInformations { get; set; }
    }
}
