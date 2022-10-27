using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficePrinterPrefrence
    {
        public int OfficePrinterPreferenceId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? PrinterTypeCdId { get; set; }
        public string? PrinterName { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual TypeCdDmt? PrinterTypeCd { get; set; }
    }
}
