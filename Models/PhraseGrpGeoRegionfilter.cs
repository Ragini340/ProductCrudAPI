using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseGrpGeoRegionfilter
    {
        public int PhraseGroupRegionFilterId { get; set; }
        public int? PhraseGroupId { get; set; }
        public int? BusinessUnitId { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual PhraseGrp? PhraseGroup { get; set; }
    }
}
