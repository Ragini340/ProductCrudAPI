using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgContact
    {
        public BusOrgContact()
        {
            BusOrgContactNotificationPrefs = new HashSet<BusOrgContactNotificationPref>();
            BusOrgContactRelationshipContacts = new HashSet<BusOrgContactRelationship>();
            BusOrgContactRelationshipParentContacts = new HashSet<BusOrgContactRelationship>();
            BusOrgContactRoleXrefs = new HashSet<BusOrgContactRoleXref>();
            BusOrgContactWebCustomerXrefs = new HashSet<BusOrgContactWebCustomerXref>();
            BusOrgRelationships = new HashSet<BusOrgRelationship>();
            BusOrgSalesForceXrefs = new HashSet<BusOrgSalesForceXref>();
            BusOrgs = new HashSet<BusOrg>();
            BusinessProgramBusOrgContactChangeHistories = new HashSet<BusinessProgramBusOrgContactChangeHistory>();
            FileBusinessParties = new HashSet<FileBusinessParty>();
            GabqueueContactHistories = new HashSet<GabqueueContactHistory>();
            OtherBusOrgs = new HashSet<OtherBusOrg>();
            PersonRelationships = new HashSet<PersonRelationship>();
            PreferredBusOrgContactXrefs = new HashSet<PreferredBusOrgContactXref>();
            TemplateBusinessParties = new HashSet<TemplateBusinessParty>();
            BusinessPrograms = new HashSet<BusinessProgram>();
        }

        public int ContactId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusOrgId { get; set; }
        public int AddrBookEntryId { get; set; }
        public int StatusCd { get; set; }
        public string? DelegateName { get; set; }
        public int? PrimarySalesEmployeeId { get; set; }
        public string? LoginName { get; set; }
        public string? LoginPassword { get; set; }
        public byte[]? UpdTs { get; set; }
        public short? StatusEmailFlag { get; set; }
        public string? CustomerPreference { get; set; }
        public long? EnterpriseId { get; set; }
        public string? EnterpriseNumber { get; set; }
        public int? OriginalContactId { get; set; }
        public int? ReferenceContactId { get; set; }

        public virtual AddrBookEntry AddrBookEntry { get; set; } = null!;
        public virtual BusOrg BusOrg { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee? PrimarySalesEmployee { get; set; }
        public virtual ICollection<BusOrgContactNotificationPref> BusOrgContactNotificationPrefs { get; set; }
        public virtual ICollection<BusOrgContactRelationship> BusOrgContactRelationshipContacts { get; set; }
        public virtual ICollection<BusOrgContactRelationship> BusOrgContactRelationshipParentContacts { get; set; }
        public virtual ICollection<BusOrgContactRoleXref> BusOrgContactRoleXrefs { get; set; }
        public virtual ICollection<BusOrgContactWebCustomerXref> BusOrgContactWebCustomerXrefs { get; set; }
        public virtual ICollection<BusOrgRelationship> BusOrgRelationships { get; set; }
        public virtual ICollection<BusOrgSalesForceXref> BusOrgSalesForceXrefs { get; set; }
        public virtual ICollection<BusOrg> BusOrgs { get; set; }
        public virtual ICollection<BusinessProgramBusOrgContactChangeHistory> BusinessProgramBusOrgContactChangeHistories { get; set; }
        public virtual ICollection<FileBusinessParty> FileBusinessParties { get; set; }
        public virtual ICollection<GabqueueContactHistory> GabqueueContactHistories { get; set; }
        public virtual ICollection<OtherBusOrg> OtherBusOrgs { get; set; }
        public virtual ICollection<PersonRelationship> PersonRelationships { get; set; }
        public virtual ICollection<PreferredBusOrgContactXref> PreferredBusOrgContactXrefs { get; set; }
        public virtual ICollection<TemplateBusinessParty> TemplateBusinessParties { get; set; }

        public virtual ICollection<BusinessProgram> BusinessPrograms { get; set; }
    }
}
