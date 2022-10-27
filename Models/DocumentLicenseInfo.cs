using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentLicenseInfo
    {
        public int DocumentLicenseInfoId { get; set; }
        public int DocId { get; set; }
        public short? NextGenFlag { get; set; }
        public int? LicensedEmployeeId { get; set; }
        public string? LicenseNo { get; set; }
        public int? FinalizedEmployeeId { get; set; }
        public DateTime? FinalizedDate { get; set; }
        public int? RequestedEmployeeId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public int? ProcessId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Employee? FinalizedEmployee { get; set; }
        public virtual Employee? LicensedEmployee { get; set; }
        public virtual Employee? RequestedEmployee { get; set; }
    }
}
