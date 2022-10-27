using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FftchangeHistory
    {
        public int FeeFilterTemplateHistoryId { get; set; }
        public int FeeFilterTemplateId { get; set; }
        public int EventTypeCdId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Notes { get; set; }

        public virtual TypeCdDmt EventTypeCd { get; set; } = null!;
        public virtual FeeFilterTemplate FeeFilterTemplate { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
