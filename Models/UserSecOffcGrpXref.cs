using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserSecOffcGrpXref
    {
        public UserSecOffcGrpXref()
        {
            Roles = new HashSet<Role>();
        }

        public int UserId { get; set; }
        public int SecOfficeGroupId { get; set; }

        public virtual SecOfficeGroup SecOfficeGroup { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;

        public virtual ICollection<Role> Roles { get; set; }
    }
}
