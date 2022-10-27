using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TemplateBusinessParty
    {
        public TemplateBusinessParty()
        {
            BusinessUnitRecFeeTemplateBusinessParties = new HashSet<BusinessUnit>();
            BusinessUnitTransferTaxesTemplateBusinessParties = new HashSet<BusinessUnit>();
            InverseSuperTemplateBusinessParty = new HashSet<TemplateBusinessParty>();
        }

        public int TemplateBusinessPartyId { get; set; }
        public int ClassTypeId { get; set; }
        public int RoleTypeCdId { get; set; }
        public int? SuperTemplateBusinessPartyId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? BusOrgId { get; set; }
        public int? PrincipalId { get; set; }
        public int? ContactId { get; set; }
        public string? AttentionName { get; set; }
        public string? RefNum { get; set; }
        public short IssueCheckFlag { get; set; }
        public int? CheckDescriptionDetailId { get; set; }
        public int? EntitySubTypeCdId { get; set; }
        public byte[]? UpdTs { get; set; }
        public int? Sales1EmployeeId { get; set; }
        public int? Sales2EmployeeId { get; set; }
        public int? BusOrgAlternateNameId { get; set; }
        public int? PhysicalAddrId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual CheckDescriptionDetail? CheckDescriptionDetail { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual BusOrgContact? Contact { get; set; }
        public virtual TypeCdDmt? EntitySubTypeCd { get; set; }
        public virtual PhysicalAddr? PhysicalAddr { get; set; }
        public virtual Principal? Principal { get; set; }
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
        public virtual Employee? Sales1Employee { get; set; }
        public virtual Employee? Sales2Employee { get; set; }
        public virtual TemplateBusinessParty? SuperTemplateBusinessParty { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitRecFeeTemplateBusinessParties { get; set; }
        public virtual ICollection<BusinessUnit> BusinessUnitTransferTaxesTemplateBusinessParties { get; set; }
        public virtual ICollection<TemplateBusinessParty> InverseSuperTemplateBusinessParty { get; set; }
    }
}
