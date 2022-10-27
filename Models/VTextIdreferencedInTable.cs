using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VTextIdreferencedInTable
    {
        public int FileId { get; set; }
        public long? TextId { get; set; }
        public string ReferencingTb { get; set; } = null!;
        public string FkId { get; set; } = null!;
    }
}
