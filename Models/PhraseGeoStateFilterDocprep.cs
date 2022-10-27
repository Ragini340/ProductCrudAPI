using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseGeoStateFilterDocprep
    {
        public int PhraseStateFilterId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int PhraseGroupId { get; set; }
        public int? GeoRegionId { get; set; }
        public bool UnderConstFlg { get; set; }

        public virtual GeographicRegion? GeoRegion { get; set; }
    }
}
