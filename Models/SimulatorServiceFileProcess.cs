using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SimulatorServiceFileProcess
    {
        public int ServiceFileProcessId { get; set; }
        public int Workflow2Id { get; set; }
        public int WorkFlowTemplateId { get; set; }
        public int OriginalTemplateId { get; set; }
        public byte? IsProcessStarted { get; set; }
        public int? TaskCount { get; set; }
        public int? CompltedCount { get; set; }
        public int? WaivedCount { get; set; }
        public int TriggerEventTypeCdId { get; set; }
        public string? EventData { get; set; }
        public byte[]? Updts { get; set; }
    }
}
