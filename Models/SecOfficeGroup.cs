using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SecOfficeGroup
    {
        public SecOfficeGroup()
        {
            EmployeeSecurityChangeHistories = new HashSet<EmployeeSecurityChangeHistory>();
            SecOffcGrpChangeHistories = new HashSet<SecOffcGrpChangeHistory>();
            UserSecOffcGrpXrefs = new HashSet<UserSecOffcGrpXref>();
            BusinessUnits = new HashSet<BusinessUnit>();
        }

        public int SecOfficeGroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public int BusinessUnitId { get; set; }
        public bool IsActive { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ICollection<EmployeeSecurityChangeHistory> EmployeeSecurityChangeHistories { get; set; }
        public virtual ICollection<SecOffcGrpChangeHistory> SecOffcGrpChangeHistories { get; set; }
        public virtual ICollection<UserSecOffcGrpXref> UserSecOffcGrpXrefs { get; set; }

        public virtual ICollection<BusinessUnit> BusinessUnits { get; set; }
    }
}
