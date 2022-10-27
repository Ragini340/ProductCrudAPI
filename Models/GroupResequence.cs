using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GroupResequence
    {
        public int GroupResequenceId { get; set; }
        public int? SectionResequenceId { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int ReSeqNum { get; set; }
        public int CreationUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public int? FileId { get; set; }
        public string? GrpKeyField { get; set; }
        public int? FpseqNum { get; set; }
        public string? MiscDescr { get; set; }
        public int? MiscDisbCustomGrpId { get; set; }

        public virtual Employee CreationUser { get; set; } = null!;
        public virtual ServiceFile? File { get; set; }
        public virtual Employee? LastModifiedUser { get; set; }
    }
}
