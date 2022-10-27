using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Role
    {
        public Role()
        {
            EmployeeSecurityChangeHistories = new HashSet<EmployeeSecurityChangeHistory>();
            ProfileChangeHistories = new HashSet<ProfileChangeHistory>();
            RoleChangeHistories = new HashSet<RoleChangeHistory>();
            RoleVisibilityXrefs = new HashSet<RoleVisibilityXref>();
            Activities = new HashSet<ActivityGrpActivityXref>();
            ProfileBusUnitXrefs = new HashSet<ProfileBusUnitXref>();
            UserBusUnitXrefs = new HashSet<UserBusUnitXref>();
            UserSecOffcGrpXrefs = new HashSet<UserSecOffcGrpXref>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; } = null!;
        public int SecurityLevelId { get; set; }
        public bool IsProtected { get; set; }
        public bool? IsActive { get; set; }
        public string? Comments { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType SecurityLevel { get; set; } = null!;
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistories { get; set; }
        public virtual ICollection<ProfileChangeHistory> ProfileChangeHistories { get; set; }
        public virtual ICollection<RoleChangeHistory> RoleChangeHistories { get; set; }
        public virtual ICollection<RoleVisibilityXref> RoleVisibilityXrefs { get; set; }

        public virtual ICollection<ActivityGrpActivityXref> Activities { get; set; }
        public virtual ICollection<ProfileBusUnitXref> ProfileBusUnitXrefs { get; set; }
        public virtual ICollection<UserBusUnitXref> UserBusUnitXrefs { get; set; }
        public virtual ICollection<UserSecOffcGrpXref> UserSecOffcGrpXrefs { get; set; }
    }
}
