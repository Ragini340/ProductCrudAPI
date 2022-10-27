using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class DataElementDmt
    {
        public DataElementDmt()
        {
            DataElementIndexTypes = new HashSet<DataElementIndexType>();
            Docphraseelements = new HashSet<Docphraseelement>();
            FieldTemplates = new HashSet<FieldTemplate>();
            PhraseElements = new HashSet<PhraseElement>();
            TemplatePhraseElements = new HashSet<TemplatePhraseElement>();
        }

        public int DataElementId { get; set; }
        public int ClassTypeId { get; set; }
        public int DataElementGrpId { get; set; }
        public string? ObjectCd { get; set; }
        public int AlignmentTypeCdId { get; set; }
        public int DataElementTypeCdId { get; set; }
        public string Descr { get; set; } = null!;
        public int? DomainTypeCdId { get; set; }
        public int? ElementSeparatorTypeCdId { get; set; }
        public int? FormatTypeCdId { get; set; }
        public int? PictureTypeCdId { get; set; }
        public int PrintCaseTypeCdId { get; set; }
        public string? PathName { get; set; }
        public string? ValueFormat { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? CatalogDescr { get; set; }
        public string? ScreenName { get; set; }
        public string? TabName { get; set; }
        public string? GridName { get; set; }
        public string? FieldName { get; set; }
        public short? StatusFlag { get; set; }
        public short? HighlightIndicator { get; set; }
        public short? ReadOnlyIndicator { get; set; }
        public string? LinqExpression { get; set; }
        public string? LinqDataType { get; set; }
        public string? LinqDataCollectionType { get; set; }

        public virtual TypeCdDmt AlignmentTypeCd { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual DataElementGrp DataElementGrp { get; set; } = null!;
        public virtual TypeCdDmt DataElementTypeCd { get; set; } = null!;
        public virtual TypeCdDmt? DomainTypeCd { get; set; }
        public virtual TypeCdDmt? ElementSeparatorTypeCd { get; set; }
        public virtual TypeCdDmt? FormatTypeCd { get; set; }
        public virtual TypeCdDmt? PictureTypeCd { get; set; }
        public virtual TypeCdDmt PrintCaseTypeCd { get; set; } = null!;
        public virtual ICollection<DataElementIndexType> DataElementIndexTypes { get; set; }
        public virtual ICollection<Docphraseelement> Docphraseelements { get; set; }
        public virtual ICollection<FieldTemplate> FieldTemplates { get; set; }
        public virtual ICollection<PhraseElement> PhraseElements { get; set; }
        public virtual ICollection<TemplatePhraseElement> TemplatePhraseElements { get; set; }
    }
}
