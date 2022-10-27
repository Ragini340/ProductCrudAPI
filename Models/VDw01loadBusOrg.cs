using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadBusOrg
    {
        public int BusOrgId { get; set; }
        public string OrgTypeCd { get; set; } = null!;
        public string? BusOrgName { get; set; }
        public string BusOrgContactName { get; set; } = null!;
        public string? AreaCode { get; set; }
        public string? PhoneNum { get; set; }
        public string? Extension { get; set; }
        public string? Email { get; set; }
        public string? OrgTypeName { get; set; }
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
