using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class SearchFactType
    {
        public int FactId { get; set; }
        public int ClassTypeId { get; set; }
        public string FactName { get; set; } = null!;
        public string? Datatype { get; set; }
        public string? TableName { get; set; }
        public string? ColumnName { get; set; }
        public int? FactContextId { get; set; }

        public virtual ClassType ClassType { get; set; } = null!;
    }
}
