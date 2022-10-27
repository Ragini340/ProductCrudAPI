using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class CdadjustableInterestRate
    {
        public int CdadjustableInterestRateId { get; set; }
        public int? ClosingDisclosureId { get; set; }
        public int? AirtypeCdId { get; set; }
        public string? Airamount { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual TypeCdDmt? AirtypeCd { get; set; }
        public virtual ClosingDisclosure? ClosingDisclosure { get; set; }
    }
}
