using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class EmployeeApplicationUserXref
    {
        public int FastemployeeId { get; set; }
        public int SourceApplId { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public string ApplicationUserPwd { get; set; } = null!;
        public short IsRemittanceScreen { get; set; }

        public virtual Application SourceAppl { get; set; } = null!;
    }
}
