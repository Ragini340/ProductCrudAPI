using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class FaccclosingCostNote
    {
        public int FaccclosingCostNoteId { get; set; }
        public int FaccclosingCostId { get; set; }
        public string? AdditionalFeeNote { get; set; }

        public virtual FaccclosingCost FaccclosingCost { get; set; } = null!;
    }
}
