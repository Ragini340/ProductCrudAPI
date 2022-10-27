using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Rtmaddress
    {
        public int RtmaddrId { get; set; }
        public int RtmpackageId { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int? FileServiceId { get; set; }
        public byte? OwningProductionOffice { get; set; }
        public int? OwningProductionOfficeId { get; set; }
        public int? PackageType { get; set; }
        public int? CourierType { get; set; }
        public bool? SingleDoubleSided { get; set; }
        public string? Attention { get; set; }
        public string? Reference { get; set; }
        public bool? IncludeReturnEnvelope { get; set; }
        public short? NumOfCopies { get; set; }
        public byte MailToReturnTo { get; set; }
        public bool? HighlightBuyer { get; set; }
        public bool? HighLightSeller { get; set; }
        public bool? HighLightMisc { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? BusOrgId { get; set; }
        public int? RtmadhocAddrId { get; set; }
        public int? PhysicalAddrTypeCdId { get; set; }
        public bool? SignatureRequired { get; set; }
        public bool? SkipAddressValidation { get; set; }
        public int? EmployeeRoleTypeCdId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual TypeCdDmt? CourierTypeNavigation { get; set; }
        public virtual TypeCdDmt? EmployeeRoleTypeCd { get; set; }
        public virtual FileBusinessParty? FileBusinessParty { get; set; }
        public virtual FileService? FileService { get; set; }
        public virtual BusinessUnit? OwningProductionOfficeNavigation { get; set; }
        public virtual TypeCdDmt? PackageTypeNavigation { get; set; }
        public virtual TypeCdDmt? PhysicalAddrTypeCd { get; set; }
        public virtual RtmfileAddress? RtmadhocAddr { get; set; }
        public virtual Rtmpackage Rtmpackage { get; set; } = null!;
    }
}
