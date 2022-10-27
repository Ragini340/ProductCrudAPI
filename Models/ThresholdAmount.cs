using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class ThresholdAmount
    {
        public ThresholdAmount()
        {
            ThresholdAmountChangeHistories = new HashSet<ThresholdAmountChangeHistory>();
        }

        public int BusSegTypeCdId { get; set; }
        public decimal? Amount { get; set; }
        public byte[] Updts { get; set; } = null!;

        public virtual TypeCdDmt BusSegTypeCd { get; set; } = null!;
        public virtual ICollection<ThresholdAmountChangeHistory> ThresholdAmountChangeHistories { get; set; }
    }
}
