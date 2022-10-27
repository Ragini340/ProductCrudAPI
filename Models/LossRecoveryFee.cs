using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class LossRecoveryFee
    {
        public int InEscrowId { get; set; }
        public int DisbursementId { get; set; }
        public int ServiceFileFeeId { get; set; }
        public byte IsActive { get; set; }

        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual InEscrowDeposit InEscrow { get; set; } = null!;
    }
}
