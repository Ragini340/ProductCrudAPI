using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class GeneratorInfo
    {
        public int GeneratorInfoId { get; set; }
        public string ObjectName { get; set; } = null!;
        public string? OrderByColumns { get; set; }
    }
}
