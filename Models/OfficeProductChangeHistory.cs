using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficeProductChangeHistory
    {
        public int OfficeProdHistoryId { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? EventTypeCdId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string? Notes { get; set; }

        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual TypeCdDmt? EventTypeCd { get; set; }
    }
}
