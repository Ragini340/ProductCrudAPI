using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverDraftDisbursementXref
    {
        public int OverDraftDisbursementXrefId { get; set; }
        public int OverDraftId { get; set; }
        public int DisbursementId { get; set; }
        public int FileId { get; set; }
        public decimal? DisbAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public int StatusTypeCdId { get; set; }
        public decimal? OverdraftAmount { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual ServiceFile File { get; set; } = null!;
        public virtual OverDraftMaster OverDraft { get; set; } = null!;
    }
}
