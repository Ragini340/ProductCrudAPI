using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DataElementIndexType
    {
        public int DataElementIndexTypeId { get; set; }
        public int ClassTypeId { get; set; }
        public int IndexTypeHeaderId { get; set; }
        public int DataElementId { get; set; }
        public short SeqNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual DataElementDmt DataElement { get; set; } = null!;
        public virtual IndexType IndexTypeHeader { get; set; } = null!;
    }
}
