using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccpolicyProductxref
    {
        public int ProductTypeCdId { get; set; }
        public int FaccpolicyId { get; set; }
        public string FaccpolicyCode { get; set; } = null!;
        public string FaccpolicyName { get; set; } = null!;
        public string FaccpolicyCategory { get; set; } = null!;
        public string Facccoverage { get; set; } = null!;
        public DateTime? UpdDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual TypeCdDmt ProductTypeCd { get; set; } = null!;
    }
}
