using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WorkflowSequence
    {
        public int WorkflowSeqId { get; set; }
        public int ClassTypeId { get; set; }
        public int WorkflowId { get; set; }
        public int UnitId { get; set; }
        public int? NextUnitId { get; set; }
        public int? NextClassTypeId { get; set; }
        public short SeqNum { get; set; }
        public short InboxFlag { get; set; }
        public short FinalEventFlag { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Workflow Workflow { get; set; } = null!;
    }
}
