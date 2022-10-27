using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LicenseInformation
    {
        public LicenseInformation()
        {
            FileBusinessPartyLicenseInformationXrefNmlslicenseInformations = new HashSet<FileBusinessPartyLicenseInformationXref>();
            FileBusinessPartyLicenseInformationXrefStateLicenseInformations = new HashSet<FileBusinessPartyLicenseInformationXref>();
            LicenseInformationLogs = new HashSet<LicenseInformationLog>();
        }

        public int LicenseInformationId { get; set; }
        public string LicenseNo { get; set; } = null!;
        public int LicenseTypeId { get; set; }
        public int? LicenseTypeGeoRegionXrefId { get; set; }
        public int LicenseEntityClassTypeId { get; set; }
        public int LicenseEntityId { get; set; }
        public int LicenseCategoryClassTypeId { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public int? DeActivationBy { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public int? ReActivationBy { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? ReferenceLicenseInformationId { get; set; }

        public virtual Employee CreationUser { get; set; } = null!;
        public virtual Employee? DeActivationByNavigation { get; set; }
        public virtual ClassType LicenseCategoryClassType { get; set; } = null!;
        public virtual ClassType LicenseEntityClassType { get; set; } = null!;
        public virtual LicenseType LicenseType { get; set; } = null!;
        public virtual LicenseTypeGeoRegionXref? LicenseTypeGeoRegionXref { get; set; }
        public virtual Employee? ReActivationByNavigation { get; set; }
        public virtual ICollection<FileBusinessPartyLicenseInformationXref> FileBusinessPartyLicenseInformationXrefNmlslicenseInformations { get; set; }
        public virtual ICollection<FileBusinessPartyLicenseInformationXref> FileBusinessPartyLicenseInformationXrefStateLicenseInformations { get; set; }
        public virtual ICollection<LicenseInformationLog> LicenseInformationLogs { get; set; }
    }
}
