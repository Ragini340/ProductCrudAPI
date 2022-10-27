using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DataElementGrp
    {
        public DataElementGrp()
        {
            DataElementDmts = new HashSet<DataElementDmt>();
        }

        public int DataElementGrpId { get; set; }
        public int ClassTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string ObjectCd { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public short? StatusFlag { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<DataElementDmt> DataElementDmts { get; set; }
    }
}
