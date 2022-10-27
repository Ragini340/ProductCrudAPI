using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ServiceFileEfileXref
    {
        public ServiceFileEfileXref()
        {
            EfileRoleTypeXrefs = new HashSet<EfileRoleTypeXref>();
        }

        public long ServiceFileEfileXrefId { get; set; }
        public int ServiceFileId { get; set; }
        public int ElectronicFileId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? Cvflag { get; set; }

        public virtual ServiceFile ServiceFile { get; set; } = null!;
        public virtual ICollection<EfileRoleTypeXref> EfileRoleTypeXrefs { get; set; }
    }
}
