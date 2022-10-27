using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FileBusinessPartyLicenseInformationXref
    {
        public int FileBusinessPartyLicenseInformationXrefId { get; set; }
        public int FileBusinessPartyId { get; set; }
        public int? NmlslicenseInformationId { get; set; }
        public string? NmlslicenseNo { get; set; }
        public int? StateLicenseInformationId { get; set; }
        public string? StateLicenseNo { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? LicenseEntityClassTypeId { get; set; }
        public short? EditNmlsflag { get; set; }
        public short? EditStateLicenseFlag { get; set; }
        public string? EditNmlslicenseNo { get; set; }
        public string? EditStateLicenseNo { get; set; }
        public int? EditStateLicenseTypeGeoRegionXrefId { get; set; }
        public int? RefStateLicenseInformationId { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual LicenseInformation? NmlslicenseInformation { get; set; }
        public virtual LicenseInformation? StateLicenseInformation { get; set; }
    }
}
