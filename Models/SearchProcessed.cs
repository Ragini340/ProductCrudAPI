using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchProcessed
    {
        public long? MovedChangeId { get; set; }
        public long? ProcessedChangeId { get; set; }
        public int? ProcessedPendingId { get; set; }
        public long? MovedNameChangeId { get; set; }
        public long? ProcessedNameChangeId { get; set; }
        public int? ProcessedNamePendingId { get; set; }
        public int SearchProcessedId { get; set; }
        public long? SolrChangeId { get; set; }
    }
}
