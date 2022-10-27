using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RegionIdforApplication
    {
        public int RegionId { get; set; }
        public int? FunctionId { get; set; }

        public virtual TypeCdDmt? Function { get; set; }
        public virtual BusinessUnit Region { get; set; } = null!;
    }
}
