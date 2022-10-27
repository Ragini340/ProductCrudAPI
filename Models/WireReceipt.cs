using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class WireReceipt
    {
        public int WireReceiptId { get; set; }
        public int IncomingWireDetailId { get; set; }
        public int InEscrowId { get; set; }
        public bool? Mrflag { get; set; }
        public string? ReceiptNum { get; set; }
        public int FileId { get; set; }
        public string? Comments { get; set; }
        public string? CreditTo { get; set; }

        public virtual ServiceFile File { get; set; } = null!;
        public virtual InEscrowDeposit InEscrow { get; set; } = null!;
        public virtual IncomingWireDetail IncomingWireDetail { get; set; } = null!;
    }
}
