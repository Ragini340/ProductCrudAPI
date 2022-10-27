using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class RemittanceSplitDetail
    {
        public int Id { get; set; }
        public string? PropertyState { get; set; }
        public int? ExternalFaccendorsementId { get; set; }
        public byte RemittanceSplitPercentage { get; set; }
    }
}
