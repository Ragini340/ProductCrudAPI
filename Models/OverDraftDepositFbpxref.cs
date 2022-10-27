using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverDraftDepositFbpxref
    {
        public int OverdraftDepositFbpid { get; set; }
        public int InEscrowId { get; set; }
        public int FileBusinessPartyId { get; set; }

        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
        public virtual InEscrowDeposit InEscrow { get; set; } = null!;
    }
}
