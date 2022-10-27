using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SolrBatchNumber
    {
        public int BatchId { get; set; }
        public string RegionIds { get; set; } = null!;
    }
}
