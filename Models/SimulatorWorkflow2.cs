using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SimulatorWorkflow2
    {
        public int Workflow2Id { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; } = null!;
        public int OrderId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public string Filenum { get; set; } = null!;
        public int OwnerOfficeId { get; set; }
        public int ServiceFilestatusCd { get; set; }
        public byte[]? Updts { get; set; }
    }
}
