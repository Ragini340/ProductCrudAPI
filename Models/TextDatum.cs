using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class TextDatum
    {
        public TextDatum()
        {
            Docphraseelements = new HashSet<Docphraseelement>();
            Docphrases = new HashSet<Docphrase>();
            ServiceFileNotes = new HashSet<ServiceFileNote>();
        }

        public long TextId { get; set; }
        public int ClassTypeId { get; set; }
        public string? TextData { get; set; }
        public byte[]? UpdTs { get; set; }
        public int FileId { get; set; }

        public virtual ICollection<Docphraseelement> Docphraseelements { get; set; }
        public virtual ICollection<Docphrase> Docphrases { get; set; }
        public virtual ICollection<ServiceFileNote> ServiceFileNotes { get; set; }
    }
}
