using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadCommitment
    {
        public int FileId { get; set; }
        public DateTime? Dwdate { get; set; }
        public int CommitmentId { get; set; }
        public short? ApprovedFlag { get; set; }
        public string Descr { get; set; } = null!;
        public string? DocTypeName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
