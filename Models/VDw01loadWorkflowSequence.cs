using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadWorkflowSequence
    {
        public int WorkflowSeqId { get; set; }
        public int WorkflowId { get; set; }
        public string? UnitTypeName { get; set; }
        public int UnitId { get; set; }
        public int? NextUnitId { get; set; }
        public string? NextUnitTypeName { get; set; }
        public short SeqNum { get; set; }
        public short InboxFlag { get; set; }
        public short FinalEventFlag { get; set; }
    }
}
