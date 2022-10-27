using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchChangeCompletedForFastc
    {
        public long ChangeId { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
        public string? Comments { get; set; }
        public DateTime? FetchedDate { get; set; }
    }
}
