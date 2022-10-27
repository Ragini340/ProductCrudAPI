using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchDependency
    {
        public int QueryId { get; set; }
        public string ObjectName { get; set; } = null!;
        public string PkcolumnName { get; set; } = null!;
        public int ObjectId { get; set; }

        public virtual SearchQuery Query { get; set; } = null!;
    }
}
