using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PhraseMarker
    {
        public PhraseMarker()
        {
            Docphrases = new HashSet<Docphrase>();
        }

        public int PhraseMarkerId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int ClassTypeId { get; set; }
        public string? Comments { get; set; }
        public short? PageBreakFlag { get; set; }
        public int? OutlineFirst { get; set; }
        public int? PhraseMarkerFormId { get; set; }
        public int FileId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual PhraseMarkerForm? PhraseMarkerForm { get; set; }
        public virtual ICollection<Docphrase> Docphrases { get; set; }
    }
}
