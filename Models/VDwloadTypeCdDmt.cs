using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDwloadTypeCdDmt
    {
        public int TypeCdId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string? Descr { get; set; }
    }
}
