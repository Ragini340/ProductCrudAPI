using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverdraftDisbursement
    {
        public int DisbursementId { get; set; }
        public int ProcessTypeCdId { get; set; }
        public string LossExplanation { get; set; } = null!;
        public int? PropertyTypeCdId { get; set; }
        public int CreatedUserId { get; set; }
        public byte[] UpdTs { get; set; } = null!;
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

        public virtual TypeCdDmt? CauseLossTypeCd { get; set; }
        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual TypeCdDmt ProcessTypeCd { get; set; } = null!;
        public virtual TypeCdDmt? TypeLossTypeCd { get; set; }
    }
}
