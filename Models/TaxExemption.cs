using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TaxExemption
    {
        public int TaxExemptionId { get; set; }
        public int ClassTypeId { get; set; }
        public int TaxId { get; set; }
        public decimal ExemptionAmt { get; set; }
        public int TaxExemptionTypeCdId { get; set; }
        public decimal? Other1 { get; set; }
        public decimal? Other2 { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Tax Tax { get; set; } = null!;
        public virtual TypeCdDmt TaxExemptionTypeCd { get; set; } = null!;
    }
}
