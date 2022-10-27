using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ActivityGrpActivityXref
    {
        public ActivityGrpActivityXref()
        {
            Roles = new HashSet<Role>();
        }

        public int ActivityGrpId { get; set; }
        public int ActivityId { get; set; }
        public short? SeqNum { get; set; }
        public byte? FormatCd { get; set; }

        public virtual Activity Activity { get; set; } = null!;
        public virtual ActivityGrp ActivityGrp { get; set; } = null!;

        public virtual ICollection<Role> Roles { get; set; }
    }
}
