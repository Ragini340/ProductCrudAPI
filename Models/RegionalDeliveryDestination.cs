using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RegionalDeliveryDestination
    {
        public int RegionalDeliveryDestinationId { get; set; }
        public int StateGeoRegionId { get; set; }
        public int CountyGeoRegionId { get; set; }
        public int? CpuproductionOfficeId { get; set; }
        public int? RegionId { get; set; }

        public virtual GeographicRegion CountyGeoRegion { get; set; } = null!;
        public virtual BusinessUnit? CpuproductionOffice { get; set; }
        public virtual BusinessUnit? Region { get; set; }
        public virtual GeographicRegion StateGeoRegion { get; set; } = null!;
    }
}
