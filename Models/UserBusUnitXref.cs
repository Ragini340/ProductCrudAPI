using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class UserBusUnitXref
    {
        public UserBusUnitXref()
        {
            Roles = new HashSet<Role>();
        }

        public int UserId { get; set; }
        public int BusinessUnitId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;

        public virtual ICollection<Role> Roles { get; set; }
    }
}
