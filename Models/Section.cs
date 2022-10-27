using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Section
    {
        public Section()
        {
            SectionResequences = new HashSet<SectionResequence>();
        }

        public int SectionId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string Descr { get; set; } = null!;
        public int SeqNum { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<SectionResequence> SectionResequences { get; set; }
    }
}
