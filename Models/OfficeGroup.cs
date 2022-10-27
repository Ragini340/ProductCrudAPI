using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficeGroup
    {
        public OfficeGroup()
        {
            Offices = new HashSet<BusinessUnit>();
        }

        public int OfficeGroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public int BusinessUnitId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;

        public virtual ICollection<BusinessUnit> Offices { get; set; }
    }
}
