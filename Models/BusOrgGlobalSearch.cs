using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class BusOrgGlobalSearch
    {
        public int BusOrgId { get; set; }
        public int ClassTypeId { get; set; }
        public int OrgTypeCdId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int StatusCd { get; set; }
        public int? AddrBookEntryId { get; set; }
        public string? BillToBusOrgName1 { get; set; }
        public string? BillToBusOrgName2 { get; set; }
        public string? BillToPersonName { get; set; }
        public int? PrimarySalesEmployeeId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? SuperBusOrgId { get; set; }
        public int? PrimaryContactId { get; set; }
        public long? TitleInsMortgageeClauseTextId { get; set; }
        public long? HazardInsLossPayeeTextId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? TitleAgentTypeCdId { get; set; }
        public string? FastStatCode { get; set; }
        public int? CorporateBusOrgId { get; set; }
        public int? ExternalCustomerFlag { get; set; }
        public int? WireInstId { get; set; }
        public short? StatusEmailFlag { get; set; }
        public int? IsNonInstitutional { get; set; }
        public short? StreamLineProcess { get; set; }
        public int? PrincipalTypeId { get; set; }
        public short? QcclosingClientFlag { get; set; }
        public string? EnterpriseNumber { get; set; }
        public long? EnterpriseId { get; set; }
        public int? OriginalBusOrgId { get; set; }
        public int? NextVersionBusOrgId { get; set; }
        public short? EcdCertifiedFlag { get; set; }
        public long? ProposedInsuredTextId { get; set; }
    }
}
