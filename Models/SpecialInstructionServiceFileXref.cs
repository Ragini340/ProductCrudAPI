using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SpecialInstructionServiceFileXref
    {
        public int SpecialInstructionServiceFileXrefId { get; set; }
        public int? InstructionId { get; set; }
        public int? FileId { get; set; }
        public string? AdhocInstructionName { get; set; }
        public int? InstructionOptionId { get; set; }
        public string? OptionValue { get; set; }

        public virtual ServiceFile? File { get; set; }
        public virtual Instruction? Instruction { get; set; }
        public virtual InstructionOptionBusUnitXref? InstructionOption { get; set; }
    }
}
