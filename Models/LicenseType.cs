using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LicenseType
    {
        public LicenseType()
        {
            LicenseInformations = new HashSet<LicenseInformation>();
            LicenseTypeGeoRegionXrefs = new HashSet<LicenseTypeGeoRegionXref>();
        }

        public int LicenseTypeId { get; set; }
        public string LicenseTypeDescr { get; set; } = null!;
        public short? IsNmlsflag { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ICollection<LicenseInformation> LicenseInformations { get; set; }
        public virtual ICollection<LicenseTypeGeoRegionXref> LicenseTypeGeoRegionXrefs { get; set; }
    }
}
