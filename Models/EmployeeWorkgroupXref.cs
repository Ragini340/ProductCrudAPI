using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeWorkgroupXref
    {
        public int EmployeeId { get; set; }
        public int? WorkgroupId { get; set; }
        public int EmployeeWorkgroupXrefId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual WorkGroup? Workgroup { get; set; }
    }
}
