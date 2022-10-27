using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class Qcstaging
    {
        public Qcstaging()
        {
            QcstagingSectionCharges = new HashSet<QcstagingSectionCharge>();
            QcstagingSectionXrefs = new HashSet<QcstagingSectionXref>();
        }

        public int QcstagingId { get; set; }
        public int FileId { get; set; }
        public int MismotypeCdId { get; set; }
        public string RequestXml { get; set; } = null!;
        public DateTime RequestDate { get; set; }
        public int AppId { get; set; }
        public int QcstatusCdId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public string? Comments { get; set; }
        public short? LenderUpdatesReviewedFlag { get; set; }
        public short? AdditionalUpdatesReviewedFlag { get; set; }
        public string? LoanCommentsXml { get; set; }

        public virtual Application App { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt MismotypeCd { get; set; } = null!;
        public virtual TypeCdDmt QcstatusCd { get; set; } = null!;
        public virtual ICollection<QcstagingSectionCharge> QcstagingSectionCharges { get; set; }
        public virtual ICollection<QcstagingSectionXref> QcstagingSectionXrefs { get; set; }
    }
}
