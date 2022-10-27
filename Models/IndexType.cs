using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class IndexType
    {
        public IndexType()
        {
            DataElementIndexTypes = new HashSet<DataElementIndexType>();
        }

        public int IndexTypeHeaderId { get; set; }
        public int ClassTypeId { get; set; }
        public string HeaderName { get; set; } = null!;
        public string ColumnName { get; set; } = null!;
        public byte[] UpdTs { get; set; } = null!;

        public virtual ClassType ClassType { get; set; } = null!;
        public virtual ICollection<DataElementIndexType> DataElementIndexTypes { get; set; }
    }
}
