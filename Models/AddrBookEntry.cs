using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class AddrBookEntry
    {
        public AddrBookEntry()
        {
            AddrBookAddrXrefs = new HashSet<AddrBookAddrXref>();
            AddrBookElecAddrXrefs = new HashSet<AddrBookElecAddrXref>();
            Akanames = new HashSet<Akaname>();
            BankBranches = new HashSet<BankBranch>();
            BusOrgContacts = new HashSet<BusOrgContact>();
            BusOrgs = new HashSet<BusOrg>();
            BusinessUnits = new HashSet<BusinessUnit>();
            Employees = new HashSet<Employee>();
            IbabankBranchAddrXrefs = new HashSet<IbabankBranchAddrXref>();
            InterfaceDeliveryRequests = new HashSet<InterfaceDeliveryRequest>();
            People = new HashSet<Person>();
            PrincipalAddrBookEntries = new HashSet<Principal>();
            PrincipalFormerAddrBookEntries = new HashSet<Principal>();
            PrincipalSpouseInfos = new HashSet<Principal>();
            RecordDocuments = new HashSet<RecordDocument>();
            RegionUnderwriters = new HashSet<RegionUnderwriter>();
            Files = new HashSet<ServiceFile>();
        }

        public int AddrBookEntryId { get; set; }
        public int ClassTypeId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Descr { get; set; }
        public string? RefNumber { get; set; }
        public string? TaxIdnum { get; set; }
        public string? Ssn { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Salutation { get; set; }
        public string? Suffix { get; set; }
        public string? Aka { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? MaritalStatusCd { get; set; }
        public short AdHocFlg { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgEmployeeId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }
        public string? Occupation { get; set; }
        public string? ConsumerMessageBoxId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee? CreationEmployee { get; set; }
        public virtual Employee? StatusChgEmployee { get; set; }
        public virtual ICollection<AddrBookAddrXref> AddrBookAddrXrefs { get; set; }
        public virtual ICollection<AddrBookElecAddrXref> AddrBookElecAddrXrefs { get; set; }
        public virtual ICollection<Akaname> Akanames { get; set; }
        public virtual ICollection<BankBranch> BankBranches { get; set; }
        public virtual ICollection<BusOrgContact> BusOrgContacts { get; set; }
        public virtual ICollection<BusOrg> BusOrgs { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<IbabankBranchAddrXref> IbabankBranchAddrXrefs { get; set; }
        public virtual ICollection<InterfaceDeliveryRequest> InterfaceDeliveryRequests { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Principal> PrincipalAddrBookEntries { get; set; }
        public virtual ICollection<Principal> PrincipalFormerAddrBookEntries { get; set; }
        public virtual ICollection<Principal> PrincipalSpouseInfos { get; set; }
        public virtual ICollection<RecordDocument> RecordDocuments { get; set; }
        public virtual ICollection<RegionUnderwriter> RegionUnderwriters { get; set; }

        public virtual ICollection<ServiceFile> Files { get; set; }
    }
}
