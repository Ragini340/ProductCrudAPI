using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Docphrase
    {
        public Docphrase()
        {
            Docphraseelements = new HashSet<Docphraseelement>();
        }

        public long DocPhraseId { get; set; }
        public int ClassTypeId { get; set; }
        public int DocId { get; set; }
        public int? PhraseId { get; set; }
        public short SeqNum { get; set; }
        public string? Name { get; set; }
        public short CustomPhraseFlag { get; set; }
        public short ExcludeFlag { get; set; }
        public short RequiredFlag { get; set; }
        public decimal? TopMarginValue { get; set; }
        public decimal? LeftMarginValue { get; set; }
        public decimal? RightMarginValue { get; set; }
        public decimal? BottomMarginValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public string? ExcludeComments { get; set; }
        public long? PhraseTextId { get; set; }
        public short? JustifyTextFlg { get; set; }
        public int? PhraseMarkerId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int FileId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
        public virtual Phrase? Phrase { get; set; }
        public virtual PhraseMarker? PhraseMarker { get; set; }
        public virtual TextDatum? TextDatum { get; set; }
        public virtual ICollection<Docphraseelement> Docphraseelements { get; set; }
    }
}
