using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdadjustablePayment
    {
        public int CdadjustablePaymentId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public int AptypeCdId { get; set; }
        public int? AppaymentScheduleTypeCdId { get; set; }
        public short? Apstatus { get; set; }
        public string? Apdescr { get; set; }
        public byte[] Updts { get; set; } = null!;
        public DateTime? ApstartDate { get; set; }
        public DateTime? ApendDate { get; set; }

        public virtual TypeCdDmt AptypeCd { get; set; } = null!;
        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
