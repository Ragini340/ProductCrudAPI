using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ProjectFileSiteFileDepositXref
    {
        public int ProjectFileSiteFileDepositXrefId { get; set; }
        public int PfinEscrowId { get; set; }
        public int SfinEscrowId { get; set; }
        public decimal? AllocatedPct { get; set; }

        public virtual InEscrowDeposit PfinEscrow { get; set; } = null!;
        public virtual InEscrowDeposit SfinEscrow { get; set; } = null!;
    }
}
