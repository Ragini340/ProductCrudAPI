using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProgramTypeSearchInstructionXref
    {
        public int SearchInstructionXrefId { get; set; }
        public int? InstructionId { get; set; }
        public int SearchInstructionId { get; set; }

        public virtual Instruction? Instruction { get; set; }
        public virtual ProgramTypeSearchInstruction SearchInstruction { get; set; } = null!;
    }
}
