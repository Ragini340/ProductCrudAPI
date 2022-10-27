using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RoleVisibilityXref
    {
        public int RoleVisibilityId { get; set; }
        public int RoleId { get; set; }
        public int? BusinessUnitId { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual Role Role { get; set; } = null!;
    }
}
