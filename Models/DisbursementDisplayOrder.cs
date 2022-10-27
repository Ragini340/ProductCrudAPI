using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DisbursementDisplayOrder
    {
        public int DisbursementDisplayId { get; set; }
        public int DisplayOrderSeqNum { get; set; }
        public int RoleTypeCdId { get; set; }
        public int ProcessTypeCdId { get; set; }

        public virtual TypeCdDmt ProcessTypeCd { get; set; } = null!;
        public virtual TypeCdDmt RoleTypeCd { get; set; } = null!;
    }
}
