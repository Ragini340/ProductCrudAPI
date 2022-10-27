using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FeeSetupChangeHistory
    {
        public int FeeSetupHistoryId { get; set; }
        public int FeeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Notes { get; set; }
        public string FeeSetupXml { get; set; } = null!;

        public virtual Employee CreatedByNavigation { get; set; } = null!;
        public virtual Fee Fee { get; set; } = null!;
    }
}
