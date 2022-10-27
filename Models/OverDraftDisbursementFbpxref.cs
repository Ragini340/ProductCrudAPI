using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OverDraftDisbursementFbpxref
    {
        public int OverdraftDisbFbpid { get; set; }
        public int DisbursementId { get; set; }
        public int FileBusinessPartyId { get; set; }

        public virtual Disbursement Disbursement { get; set; } = null!;
        public virtual FileBusinessParty FileBusinessParty { get; set; } = null!;
    }
}
