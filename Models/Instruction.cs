using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Instruction
    {
        public Instruction()
        {
            InstructionBusOrgXrefs = new HashSet<InstructionBusOrgXref>();
            InstructionOptionBusUnitXrefs = new HashSet<InstructionOptionBusUnitXref>();
            ProgramTypeSearchInstructionXrefs = new HashSet<ProgramTypeSearchInstructionXref>();
            SpecialInstructionServiceFileXrefs = new HashSet<SpecialInstructionServiceFileXref>();
        }

        public int InstructionId { get; set; }
        public string? InstructionName { get; set; }
        public int? BusinessUnitId { get; set; }
        public short? StatusCd { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CreationEmployeeId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? Reactivationdate { get; set; }
        public int? UpdatedEmployeeId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public int? StatusChangeUserId { get; set; }
        public string? StatusChgComments { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public byte? SearchInstructionFlag { get; set; }
        public byte? FileInstructionFlag { get; set; }
        public byte? AdhocInstructionFlag { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual Employee? CreationEmployee { get; set; }
        public virtual Employee? StatusChangeUser { get; set; }
        public virtual Employee? UpdatedEmployee { get; set; }
        public virtual ICollection<InstructionBusOrgXref> InstructionBusOrgXrefs { get; set; }
        public virtual ICollection<InstructionOptionBusUnitXref> InstructionOptionBusUnitXrefs { get; set; }
        public virtual ICollection<ProgramTypeSearchInstructionXref> ProgramTypeSearchInstructionXrefs { get; set; }
        public virtual ICollection<SpecialInstructionServiceFileXref> SpecialInstructionServiceFileXrefs { get; set; }
    }
}
