using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdpayoffsandPayment
    {
        public int CdpayoffPaymentsId { get; set; }
        public int ClosingDisclosureId { get; set; }
        public string? ChargeDescr { get; set; }
        public decimal? Amount { get; set; }

        public virtual ClosingDisclosure ClosingDisclosure { get; set; } = null!;
    }
}
