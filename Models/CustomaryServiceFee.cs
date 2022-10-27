using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CustomaryServiceFee
    {
        public int CustomaryServiceFeeId { get; set; }
        public int ClassTypeId { get; set; }
        public int TypeCdId { get; set; }
        public int FeeId { get; set; }
        public int SeqNum { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Fee Fee { get; set; } = null!;
        public virtual TypeCdDmt TypeCd { get; set; } = null!;
    }
}
