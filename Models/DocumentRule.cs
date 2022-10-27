using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DocumentRule
    {
        public int DocumentRuleId { get; set; }
        public int DocRuleTypeId { get; set; }
        public int GeoRegionId { get; set; }
        public int StatusCd { get; set; }

        public virtual TypeCdDmt DocRuleType { get; set; } = null!;
        public virtual GeographicRegion GeoRegion { get; set; } = null!;
    }
}
