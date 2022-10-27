using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class QcstagingSectionXref
    {
        public QcstagingSectionXref()
        {
            QcstagingSectionCharges = new HashSet<QcstagingSectionCharge>();
        }

        public int QcstagingSectionXrefId { get; set; }
        public int QcstagingId { get; set; }
        public int SectionTypeCdId { get; set; }
        public int SectionStatus { get; set; }
        public string? Comments { get; set; }
        public DateTime ProcessedDate { get; set; }
        public int UserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime? CommentsSentDate { get; set; }
        public bool? CommentsSentStatus { get; set; }
        public bool IsAddlLenderUpdateSection { get; set; }

        public virtual Qcstaging Qcstaging { get; set; } = null!;
        public virtual TypeCdDmt SectionTypeCd { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
        public virtual ICollection<QcstagingSectionCharge> QcstagingSectionCharges { get; set; }
    }
}
