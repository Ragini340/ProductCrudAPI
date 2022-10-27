using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class InstructionBusOrgXref
    {
        public int? InstructionId { get; set; }
        public int? BusOrgId { get; set; }
        public int InstructionBusOrgXrefId { get; set; }

        public virtual BusOrg? BusOrg { get; set; }
        public virtual Instruction? Instruction { get; set; }
    }
}
