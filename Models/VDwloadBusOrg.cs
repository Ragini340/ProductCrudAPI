using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadBusOrg
    {
        public int BusOrgId { get; set; }
        public string OrgTypeCd { get; set; } = null!;
        public string? BusOrgName { get; set; }
        public string BusOrgContactName { get; set; } = null!;
        public string? OrgTypeName { get; set; }
        public int StatusCd { get; set; }
        public string BillToBusOrgName1 { get; set; } = null!;
        public string BillToBusOrgName2 { get; set; } = null!;
        public string BillToPersonName { get; set; } = null!;
        public int? PrimarySalesEmployeeId { get; set; }
        public int? BusinessUnitId { get; set; }
        public string DelegateName { get; set; } = null!;
        public string? AreaCode { get; set; }
        public string? PhoneNum { get; set; }
        public string? Extension { get; set; }
        public string? FaxNum { get; set; }
        public string? Email { get; set; }
        public string? AddrLine1 { get; set; }
        public string? AddrLine2 { get; set; }
        public string? AddrLine3 { get; set; }
        public string? AddrLine4 { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
    }
}
