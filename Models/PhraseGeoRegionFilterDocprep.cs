using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseGeoRegionFilterDocprep
    {
        public int PhraseRegionFilterId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public int PhraseGroupId { get; set; }
        public int? BusinessUnitId { get; set; }
        public bool UnderConstFlg { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
    }
}
