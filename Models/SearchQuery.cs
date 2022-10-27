using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchQuery
    {
        public int QueryId { get; set; }
        public string QueryStr { get; set; } = null!;
        public string? QueryWhereClause { get; set; }
    }
}
