using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverDraftMaster
    {
        public OverDraftMaster()
        {
            OverDraftDisbursementXrefs = new HashSet<OverDraftDisbursementXref>();
            OverDraftFbpxrefs = new HashSet<OverDraftFbpxref>();
            OverDraftInEscrowDepositLinks = new HashSet<OverDraftInEscrowDepositLink>();
            OverDraftInEscrowDepositXrefs = new HashSet<OverDraftInEscrowDepositXref>();
        }

        public int OverDraftId { get; set; }
        public int ProcessTypeCdId { get; set; }
        public string? LossExplanation { get; set; }
        public int? PropertyTypeCdId { get; set; }
        public int CreatedUserId { get; set; }
        public bool? TableFunding { get; set; }
        public short? LossRecoverable { get; set; }
        public string? LossNotRecoverExplanation { get; set; }
        public decimal? AmountRecoverable { get; set; }
        public int? TypeLossTypeCdId { get; set; }
        public string? OtherTypeExplanation { get; set; }
        public int? CauseLossTypeCdId { get; set; }
        public string? OtherCauseExplanation { get; set; }
        public bool? DepositImmediately { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? RequestOverDraftAmount { get; set; }
        public int FileId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string? GroupCode { get; set; }
        public short? OverdraftStatus { get; set; }
        public int? ApprovedUserId { get; set; }
        public bool? TableFundingEnabled { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public short? OverDraftLockStatus { get; set; }
        public short? OverDraftType { get; set; }
        public string? OverdraftComments { get; set; }

        public virtual TypeCdDmt? CauseLossTypeCd { get; set; }
        public virtual ServiceFile File { get; set; } = null!;
        public virtual TypeCdDmt ProcessTypeCd { get; set; } = null!;
        public virtual TypeCdDmt? TypeLossTypeCd { get; set; }
        public virtual ICollection<OverDraftDisbursementXref> OverDraftDisbursementXrefs { get; set; }
        public virtual ICollection<OverDraftFbpxref> OverDraftFbpxrefs { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositLink> OverDraftInEscrowDepositLinks { get; set; }
        public virtual ICollection<OverDraftInEscrowDepositXref> OverDraftInEscrowDepositXrefs { get; set; }
    }
}
