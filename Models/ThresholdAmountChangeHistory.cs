using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ThresholdAmountChangeHistory
    {
        public string Event { get; set; } = null!;
        public int UserId { get; set; }
        public int BusSegTypeCdId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ThresholdAmountChangeHistoryId { get; set; }

        public virtual ThresholdAmount BusSegTypeCd { get; set; } = null!;
        public virtual Employee User { get; set; } = null!;
    }
}
