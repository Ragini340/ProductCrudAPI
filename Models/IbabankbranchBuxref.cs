using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IbabankbranchBuxref
    {
        public int IbabankbranchBuxrefId { get; set; }
        public int IbabankId { get; set; }
        public int? FileId { get; set; }
        public int? BusinessUnitId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual IbabankBranch Ibabank { get; set; } = null!;
    }
}
