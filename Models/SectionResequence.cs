using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SectionResequence
    {
        public int SectionResequenceId { get; set; }
        public int SectionId { get; set; }
        public int FileId { get; set; }
        public int? ReSeqNum { get; set; }
        public short? SubTotalFlag { get; set; }
        public int CreationUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Description { get; set; }
        public string? SubSection { get; set; }

        public virtual Employee CreationUser { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual Employee? LastModifiedUser { get; set; }
        public virtual Section Section { get; set; } = null!;
    }
}
