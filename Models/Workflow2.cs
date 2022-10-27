using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Workflow2
    {
        public int WorkFlow2Id { get; set; }
        public int ClassTypeId { get; set; }
        public int ServiceTypeCdId { get; set; }
        public int CreationUserId { get; set; }
        public int StatusCd { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[]? UpdTs { get; set; }
        public int FileId { get; set; }
        public string? Name { get; set; }
        public int? WorkFlowTemplateId { get; set; }
        public int? ImportCount { get; set; }
        public int? OrderId { get; set; }
        public string? FileNum { get; set; }
        public int? RegionId { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual BusinessUnit? Region { get; set; }
    }
}
