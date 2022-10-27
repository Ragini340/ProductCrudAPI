using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class VDw01loadApplication
    {
        public int ApplId { get; set; }
        public string ObjectCd { get; set; } = null!;
        public string ApplType { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Comments { get; set; }
    }
}
