using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Profile
    {
        public Profile()
        {
            EmployeeSecurityChangeHistories = new HashSet<EmployeeSecurityChangeHistory>();
            ProfileBusUnitXrefs = new HashSet<ProfileBusUnitXref>();
            ProfileChangeHistories = new HashSet<ProfileChangeHistory>();
            Users = new HashSet<Employee>();
        }

        public int ProfileId { get; set; }
        public string Name { get; set; } = null!;
        public int HomeRegionId { get; set; }
        public bool? IsActive { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public int? UpdateEmployeeId { get; set; }
        public DateTime? DeActivationDate { get; set; }
        public DateTime? ReActivationDate { get; set; }
        public string? Comments { get; set; }

        public virtual BusinessUnit HomeRegion { get; set; } = null!;
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistories { get; set; }
        public virtual ICollection<ProfileBusUnitXref> ProfileBusUnitXrefs { get; set; }
        public virtual ICollection<ProfileChangeHistory> ProfileChangeHistories { get; set; }

        public virtual ICollection<Employee> Users { get; set; }
    }
}
