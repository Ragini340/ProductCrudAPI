using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeOverdraftEmailOptOutList
    {
        public int EmployeeId { get; set; }
        public int BusinessUnitId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
