using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InstructionOptionBusUnitXref
    {
        public InstructionOptionBusUnitXref()
        {
            SpecialInstructionServiceFileXrefs = new HashSet<SpecialInstructionServiceFileXref>();
        }

        public int InstructionOptionId { get; set; }
        public int? InstructionId { get; set; }
        public int? BusinessUnitId { get; set; }
        public string? OptionValue { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual Instruction? Instruction { get; set; }
        public virtual ICollection<SpecialInstructionServiceFileXref> SpecialInstructionServiceFileXrefs { get; set; }
    }
}
