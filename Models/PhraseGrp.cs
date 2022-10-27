using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseGrp
    {
        public PhraseGrp()
        {
            PhraseGeoRegionFilters = new HashSet<PhraseGeoRegionFilter>();
            PhraseGeoStateFilters = new HashSet<PhraseGeoStateFilter>();
            PhraseGrpGeoRegionfilters = new HashSet<PhraseGrpGeoRegionfilter>();
            PhraseGrpGeoStateFilters = new HashSet<PhraseGrpGeoStateFilter>();
            Phrases = new HashSet<Phrase>();
        }

        public int PhraseGrpId { get; set; }
        public int ClassTypeId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int PhraseTypeCdId { get; set; }
        public string FontName { get; set; } = null!;
        public short FontSize { get; set; }
        public short InheritFlag { get; set; }
        public decimal? TopMarginValue { get; set; }
        public decimal? LeftMarginValue { get; set; }
        public decimal? RightMarginValue { get; set; }
        public decimal? BottomMarginValue { get; set; }
        public byte[]? UpdTs { get; set; }
        public string? Comments { get; set; }
        public int BusinessUnitId { get; set; }
        public int StatusCd { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual TypeCdDmt PhraseTypeCd { get; set; } = null!;
        public virtual ICollection<PhraseGeoRegionFilter> PhraseGeoRegionFilters { get; set; }
        public virtual ICollection<PhraseGeoStateFilter> PhraseGeoStateFilters { get; set; }
        public virtual ICollection<PhraseGrpGeoRegionfilter> PhraseGrpGeoRegionfilters { get; set; }
        public virtual ICollection<PhraseGrpGeoStateFilter> PhraseGrpGeoStateFilters { get; set; }
        public virtual ICollection<Phrase> Phrases { get; set; }
    }
}
