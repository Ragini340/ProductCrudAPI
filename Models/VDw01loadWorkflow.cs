using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadWorkflow
    {
        public int WorkflowId { get; set; }
        public int BusinessUnitId { get; set; }
        public string? ServiceTypeName { get; set; }
        public string Name { get; set; } = null!;
        public int StatusCd { get; set; }
        public short SubWorkflowFlag { get; set; }
    }
}
