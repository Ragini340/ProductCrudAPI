using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProfileBusUnitXref
    {
        public ProfileBusUnitXref()
        {
            Roles = new HashSet<Role>();
        }

        public int ProfileId { get; set; }
        public int BusinessUnitId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual Profile Profile { get; set; } = null!;

        public virtual ICollection<Role> Roles { get; set; }
    }
}
