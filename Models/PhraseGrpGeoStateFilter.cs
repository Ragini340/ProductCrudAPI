using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseGrpGeoStateFilter
    {
        public int PhraseGroupStateFilterId { get; set; }
        public int PhraseGroupId { get; set; }
        public int? GeoRegionId { get; set; }

        public virtual GeographicRegion? GeoRegion { get; set; }
        public virtual PhraseGrp PhraseGroup { get; set; } = null!;
    }
}
