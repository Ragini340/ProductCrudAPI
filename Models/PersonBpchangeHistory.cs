using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class PersonBpchangeHistory
    {
        public int PersonBpchangeHistoryId { get; set; }
        public int PersonId { get; set; }
        public int EventTypeCdId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string? Notes { get; set; }

        public virtual Employee CreatedByNavigation { get; set; } = null!;
        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
        public virtual Person Person { get; set; } = null!;
    }
}
