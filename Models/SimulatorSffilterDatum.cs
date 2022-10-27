using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SimulatorSffilterDatum
    {
        public int FileId { get; set; }
        public string Filenum { get; set; } = null!;
        public int OrderId { get; set; }
        public int Workflow2Id { get; set; }
        public int? BusSegTypeCdId { get; set; }
        public int? TransTypeCdId { get; set; }
        public int? ServiceTypeCdId { get; set; }
        public int? BusinessSourceRoleId { get; set; }
        public int? DirectedByRoleId { get; set; }
        public int? AssociatedPartyRoleId { get; set; }
        public int? OwnerOfficeId { get; set; }
        public int? RegionId { get; set; }
        public byte[]? Updts { get; set; }
        public int? ProgramTypeId { get; set; }
        public int? SearchTypeCdId { get; set; }
        public int? CreationUserId { get; set; }
        public int? PropertyTypeCdId { get; set; }
        public int? OrderSourceId { get; set; }
        public int? OrderSourceId2 { get; set; }
        public int? SecondOrderOriginatorId { get; set; }
        public int? OrderOriginatorId { get; set; }
        public int? ApnTypeCdId { get; set; }

        public virtual Application? OrderSourceId2Navigation { get; set; }
    }
}
