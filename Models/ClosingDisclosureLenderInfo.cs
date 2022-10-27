using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClosingDisclosureLenderInfo
    {
        public int CdlenderInfoId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public int? RoleTypeCdId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Nmlsid { get; set; }
        public string? Slsid { get; set; }
        public string? Contact { get; set; }
        public string? ContactNmlsid { get; set; }
        public string? ContactSlsid { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Extension { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? PhysicalAddrId { get; set; }

        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
        public virtual PhysicalAddr? PhysicalAddr { get; set; }
        public virtual TypeCdDmt? RoleTypeCd { get; set; }
    }
}
