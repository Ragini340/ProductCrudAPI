using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Workflow
    {
        public Workflow()
        {
            ServiceFiles = new HashSet<ServiceFile>();
            WorkflowSequences = new HashSet<WorkflowSequence>();
        }

        public int WorkflowId { get; set; }
        public int ClassTypeId { get; set; }
        public int BusinessUnitId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public short SubWorkflowFlag { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUserId { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public DateTime? ReactivationDate { get; set; }
        public DateTime? StatusChgDate { get; set; }
        public int? StatusChgUserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public string? StatusChgComments { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Employee CreationUser { get; set; } = null!;
        public virtual TypeCdDmt ServiceTypeCd { get; set; } = null!;
        public virtual Employee? StatusChgUser { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
        public virtual ICollection<WorkflowSequence> WorkflowSequences { get; set; }
    }
}
