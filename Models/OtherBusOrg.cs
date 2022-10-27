using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OtherBusOrg
    {
        public OtherBusOrg()
        {
            TitleEscrowInfos = new HashSet<TitleEscrowInfo>();
        }

        public int OtherBusOrgId { get; set; }
        public int ClassTypeId { get; set; }
        public int? BusOrgId { get; set; }
        public int? BusOrgContactId { get; set; }
        public short StaticSeqNum { get; set; }
        public string? RefNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual BusOrg? BusOrg { get; set; }
        public virtual BusOrgContact? BusOrgContact { get; set; }
        public virtual ClassType ClassType { get; set; } = null!;

        public virtual ICollection<TitleEscrowInfo> TitleEscrowInfos { get; set; }
    }
}
