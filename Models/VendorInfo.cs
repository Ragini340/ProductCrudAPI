using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VendorInfo
    {
        public int VendorId { get; set; }
        public int VendorTypeCdId { get; set; }
        public int EmployeeId { get; set; }
        public string? VendorUserName { get; set; }
        public string? VendorPassword { get; set; }
        public string? VendorAcctNum { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual TypeCdDmt VendorTypeCd { get; set; } = null!;
    }
}
