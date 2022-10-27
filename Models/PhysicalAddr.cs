using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhysicalAddr
    {
        public PhysicalAddr()
        {
            AddrBookAddrXrefs = new HashSet<AddrBookAddrXref>();
            BusOrgAndContactPhysicalAddrXrefOriginalPhysicalAddrs = new HashSet<BusOrgAndContactPhysicalAddrXref>();
            BusOrgAndContactPhysicalAddrXrefPhysicalAddrs = new HashSet<BusOrgAndContactPhysicalAddrXref>();
            Charges = new HashSet<Charge>();
            ClosingDisclosureLenderInfos = new HashSet<ClosingDisclosureLenderInfo>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            PolicyPhysicalAddrXrefs = new HashSet<PolicyPhysicalAddrXref>();
            SffphysicalAddrs = new HashSet<SffphysicalAddr>();
            SigningAddrXrefs = new HashSet<SigningAddrXref>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
            Policies = new HashSet<ServiceFileDocumentXref>();
            Properties = new HashSet<RealProperty>();
        }

        public int PhysicalAddrId { get; set; }
        public int ClassTypeId { get; set; }
        public int? ContextTypeCdId { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public string? AddrLine3 { get; set; }
        public string? AddrLine4 { get; set; }
        public string? City { get; set; }
        public string? CityVanityName { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? AreaLocator { get; set; }
        public string? TaxRoleCd { get; set; }
        public string? Msa { get; set; }
        public string? CensusTract { get; set; }
        public string? AlphaIndex { get; set; }
        public string? NumericIndex { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public long? EnterpriseId { get; set; }
        public int? StatusCd { get; set; }
        public short? FastprimaryFlag { get; set; }
        public short? MdmprimaryFlag { get; set; }
        public short? LocalPrimaryFlag { get; set; }
        public short? ValidFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<AddrBookAddrXref> AddrBookAddrXrefs { get; set; }
        public virtual ICollection<BusOrgAndContactPhysicalAddrXref> BusOrgAndContactPhysicalAddrXrefOriginalPhysicalAddrs { get; set; }
        public virtual ICollection<BusOrgAndContactPhysicalAddrXref> BusOrgAndContactPhysicalAddrXrefPhysicalAddrs { get; set; }
        public virtual ICollection<Charge> Charges { get; set; }
        public virtual ICollection<ClosingDisclosureLenderInfo> ClosingDisclosureLenderInfos { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<PolicyPhysicalAddrXref> PolicyPhysicalAddrXrefs { get; set; }
        public virtual ICollection<SffphysicalAddr> SffphysicalAddrs { get; set; }
        public virtual ICollection<SigningAddrXref> SigningAddrXrefs { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }

        public virtual ICollection<ServiceFileDocumentXref> Policies { get; set; }
        public virtual ICollection<RealProperty> Properties { get; set; }
    }
}
