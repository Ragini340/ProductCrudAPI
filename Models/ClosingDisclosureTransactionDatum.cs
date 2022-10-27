using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ClosingDisclosureTransactionDatum
    {
        public int ClosingDisclosureTransactionDataId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? FileBusinessPartyId { get; set; }
        public int? AddrTypeCdId { get; set; }
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
        public virtual FileBusinessParty? FileBusinessParty { get; set; }
    }
}
