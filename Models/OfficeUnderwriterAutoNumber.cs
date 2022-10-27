using System;
using System.Collections.Generic;

namespace ProductCrudAPI.Models
{
    public partial class OfficeUnderwriterAutoNumber
    {
        public int OfficeUnderwriterId { get; set; }
        public short AutoPolicyNumber { get; set; }
        public string? Prefix1 { get; set; }
        public int? StartRange1 { get; set; }
        public int? EndRange1 { get; set; }
        public string? Prefix2 { get; set; }
        public int? StartRange2 { get; set; }
        public int? EndRange2 { get; set; }
        public int? NextNumber { get; set; }

        public virtual OfficeUnderwriter OfficeUnderwriter { get; set; } = null!;
    }
}
