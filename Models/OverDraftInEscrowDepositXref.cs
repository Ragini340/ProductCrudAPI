using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverDraftInEscrowDepositXref
    {
        public int OverDraftInEscrowDepositXrefId { get; set; }
        public int OverDraftId { get; set; }
        public int InEscrowId { get; set; }
        public int FileId { get; set; }
        public decimal? OverdraftAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public int? StatusTypeCdId { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual ServiceFile File { get; set; } = null!;
        public virtual InEscrowDeposit InEscrow { get; set; } = null!;
        public virtual OverDraftMaster OverDraft { get; set; } = null!;
    }
}
