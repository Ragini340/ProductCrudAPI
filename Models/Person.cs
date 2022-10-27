using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            BusOrgContactRelationships = new HashSet<BusOrgContactRelationship>();
            BusOrgRelationships = new HashSet<BusOrgRelationship>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            PersonBpchangeHistories = new HashSet<PersonBpchangeHistory>();
            PersonNotificationPrefs = new HashSet<PersonNotificationPref>();
            PersonRelationshipParentPeople = new HashSet<PersonRelationship>();
            PersonRelationshipPeople = new HashSet<PersonRelationship>();
            PersonWebCustomerXrefs = new HashSet<PersonWebCustomerXref>();
            PreferredPersonXrefs = new HashSet<PreferredPersonXref>();
            BusinessPrograms = new HashSet<BusinessProgram>();
        }

        public int PersonId { get; set; }
        public int AddrBookEntryId { get; set; }
        public int StatusCd { get; set; }
        public string? DelegateName { get; set; }
        public string? CustomerPreference { get; set; }
        public int? SalesRep1 { get; set; }
        public int? SalesRep2 { get; set; }
        public int? WireInstId { get; set; }
        public long? EnterpriseId { get; set; }
        public string? EnterpriseNumber { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? ObjectCd { get; set; }
        public int? BusinessUnitId { get; set; }
        public short? StatusEmailFlag { get; set; }

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
        public virtual Employee? SalesRep1Navigation { get; set; }
        public virtual Employee? SalesRep2Navigation { get; set; }
        public virtual BusOrgWireInstruction? WireInst { get; set; }
        public virtual ICollection<BusOrgContactRelationship> BusOrgContactRelationships { get; set; }
        public virtual ICollection<BusOrgRelationship> BusOrgRelationships { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<PersonBpchangeHistory> PersonBpchangeHistories { get; set; }
        public virtual ICollection<PersonNotificationPref> PersonNotificationPrefs { get; set; }
        public virtual ICollection<PersonRelationship> PersonRelationshipParentPeople { get; set; }
        public virtual ICollection<PersonRelationship> PersonRelationshipPeople { get; set; }
        public virtual ICollection<PersonWebCustomerXref> PersonWebCustomerXrefs { get; set; }
        public virtual ICollection<PreferredPersonXref> PreferredPersonXrefs { get; set; }

        public virtual ICollection<BusinessProgram> BusinessPrograms { get; set; }
    }
}
