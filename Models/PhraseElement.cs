using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseElement
    {
        public int PhraseElementId { get; set; }
        public int ClassTypeId { get; set; }
        public int PhraseId { get; set; }
        public short SeqNum { get; set; }
        public int DataElementId { get; set; }
        public string ElementIndex { get; set; } = null!;
        public int AlignmentTypeCdId { get; set; }
        public short CustomElementFlag { get; set; }
        public string Descr { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public int? ElementSeparatorTypeCdId { get; set; }
        public int? FormatTypeCdId { get; set; }
        public int? PictureTypeCdId { get; set; }
        public int PrintCaseTypeCdId { get; set; }
        public short RequiredFlag { get; set; }
        public decimal? Xcoordinate { get; set; }
        public decimal? Ycoordinate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public short? ReadOnlyFlag { get; set; }
        public string? FormFieldName { get; set; }
        public string? InitialValue { get; set; }
        public short? HighlightIndicator { get; set; }
        public short? ReadOnlyIndicator { get; set; }

        public virtual TypeCdDmt AlignmentTypeCd { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual DataElementDmt DataElement { get; set; } = null!;
        public virtual TypeCdDmt? ElementSeparatorTypeCd { get; set; }
        public virtual TypeCdDmt? FormatTypeCd { get; set; }
        public virtual Phrase Phrase { get; set; } = null!;
        public virtual TypeCdDmt? PictureTypeCd { get; set; }
        public virtual TypeCdDmt PrintCaseTypeCd { get; set; } = null!;
    }
}
