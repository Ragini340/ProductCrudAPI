using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeSearchInstruction
    {
        public ProgramTypeSearchInstruction()
        {
            ProgramTypeSearchInstructionXrefs = new HashSet<ProgramTypeSearchInstructionXref>();
        }

        public int SearchInstructionId { get; set; }
        public int? FileId { get; set; }
        public int? SearchVendorTypeCdId { get; set; }
        public int? SearchTypeTypeCdId { get; set; }
        public int? SeqNum { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual SearchType? SearchTypeTypeCd { get; set; }
        public virtual TypeCdDmt? SearchVendorTypeCd { get; set; }
        public virtual ICollection<ProgramTypeSearchInstructionXref> ProgramTypeSearchInstructionXrefs { get; set; }
    }
}
